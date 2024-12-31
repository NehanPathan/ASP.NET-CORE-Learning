using Microsoft.AspNetCore.Mvc.Filters;

namespace CRUDExample.Filters.ActionFilters
{
    public class ResponseHeaderFilterFactoryAttribute : Attribute, IFilterFactory
    {
        public bool IsReusable => false;
        private readonly string? _key;
        private readonly string? _value;
        private readonly int _order;

        public ResponseHeaderFilterFactoryAttribute(string key, string value, int order)
        {
            _key = key;
            _value = value;
            _order = order;
        }

        public IFilterMetadata CreateInstance(IServiceProvider serviceProvider)
        {
            var filter = serviceProvider.GetRequiredService<ResponseHeaderActionFilter>();
            filter.Key = _key;
            filter.Value = _value;
            filter.Order = _order;

            return filter;
        }
    }

    public class ResponseHeaderActionFilter : IAsyncActionFilter, IOrderedFilter
    {
        public string? Key { get; set; }
        public string? Value { get; set; }
        public int Order { get; set; }
        private readonly ILogger<ResponseHeaderActionFilter> _logger;

        public ResponseHeaderActionFilter(ILogger<ResponseHeaderActionFilter> logger)
        {
            _logger = logger;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            _logger.LogInformation("Before logic - ResponseHeaderActionFilter");

            await next(); // calls the subsequent filter or action method

            _logger.LogInformation("After logic - ResponseHeaderActionFilter");

            if (!string.IsNullOrEmpty(Key) && !string.IsNullOrEmpty(Value))
            {
                context.HttpContext.Response.Headers[Key] = Value;
            }
        }
    }
}
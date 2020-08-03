using Library.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Library.API.OperationFilters
{
    public class GetBookOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.OperationId != "GetBook")
            {
                return;
            }

            if (!context.SchemaRepository.Schemas.TryGetValue(nameof(BookWithConcatenatedAuthorName), out var schema))
            {
                schema = context.SchemaGenerator.GenerateSchema(typeof(BookWithConcatenatedAuthorName), context.SchemaRepository);
            }

            operation.Responses[StatusCodes.Status200OK.ToString()].Content.Add("application/vnd.marvin.bookwithconcatanatedauthorname+json",
                new OpenApiMediaType()
                {
                    Schema = schema
                });

        }
    }
}
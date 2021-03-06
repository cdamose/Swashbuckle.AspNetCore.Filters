﻿using System.Collections.Generic;
using Swashbuckle.AspNetCore.Filters;

namespace WebApi.Models.Examples
{
    internal class PersonResponseMultipleExamples : IMultipleExamplesProvider<PersonResponse>
    {
        public IEnumerable<SwaggerExample<PersonResponse>> GetExamples()
        {
            yield return new SwaggerExample<PersonResponse>()
            {
                Name = "John",
                Summary = "can return John",
                Value = new PersonResponse {Id = 123, Title = Title.Dr, FirstName = "John", LastName = "Doe", Age = 27, Income = null}
            };
            yield return new SwaggerExample<PersonResponse>()
            {
                Name = "Angela",
                Summary = "or Angela",
                Value = new PersonResponse {Id = 124, Title = Title.Miss, FirstName = "Angela", LastName = "Doe", Age = 28, Income = null}
            };
        }
    }
}
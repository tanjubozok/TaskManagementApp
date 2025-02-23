using FluentValidation.Results;
using TaskManagementApp.Application.Dtos;

namespace TaskManagementApp.Application.Extensions;

public static class ValidationExtensions
{
    public static List<ValidationError> ToMap(this List<ValidationFailure> errors)
    {
        var errorList = new List<ValidationError>();
        foreach (var error in errors)
        {
            errorList.Add(new ValidationError(error.PropertyName, error.ErrorMessage));
        }
        return errorList;
    }
}

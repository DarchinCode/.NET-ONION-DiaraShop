﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Framework.Application;

public class FileExtensionLimitationAttribute : ValidationAttribute, IClientModelValidator
{
    private readonly string[] _validExtensions;

    public FileExtensionLimitationAttribute(string[] validExtensions)
    {
        _validExtensions = validExtensions;
    }

    public override bool IsValid(object? value)
    {
        var file = value as IFormFile;
        if (file == null) return true;
        var fileExtension = Path.GetExtension(file.FileName);
        return _validExtensions.Contains(fileExtension);
    }

    public void AddValidation(ClientModelValidationContext context)
    {
        //context.Attributes.Add("data-val", "true");
        context.Attributes.Add("data-val-fileExtensionLimit", ErrorMessage);
    }
}
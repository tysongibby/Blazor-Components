﻿using BebComponents.DataModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Linq.Expressions;

namespace BebComponents
{
    public partial class ESelect
    {
        [Parameter, EditorRequired]
        public Expression<Func<string>> ValidationFor { get; set; } = default!;
        [Parameter]
        public string? Id { get; set; } = "ESelect";
        [Parameter]
        public string? Label { get; set; }
        [Parameter]
        public bool? FloatingLabel { get; set; } = false;
        [Parameter]
        public List<SelectOption> Options { get; set; }
        [Parameter]
        public SelectOption? SelectedOption { get; set; }
        [Parameter]
        public Action? Trigger { get; set; }

        protected override bool TryParseValueFromString(string? value, out string result, out string validationErrorMessage)
        {            
            result = value; 
            validationErrorMessage = null;
            return true;
        }

        public void OnClick(SelectOption option)
        {
            SelectedOption = option;            
            Trigger?.Invoke();
        }

    }
}
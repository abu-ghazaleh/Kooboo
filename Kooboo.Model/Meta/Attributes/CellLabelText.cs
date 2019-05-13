﻿using System;
using System.Collections.Generic;
using System.Text; 

namespace Kooboo.Model.Meta.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CellLabelText : Attribute, IMetaAttribute
    {
        public bool IsHeader => false;

        public string PropertyName => "text";

        public string TrueText { get; set; }

        public string FalseText { get; set; }

        public CellLabelText(string trueText,string falseText)
        {
            TrueText = trueText;
            FalseText = falseText;
        }

        public object Value()
        {
            var dic = new Dictionary<bool, string>();
            dic.Add(true, TrueText);
            dic.Add(false, FalseText);
            return dic;
        }
    }
}
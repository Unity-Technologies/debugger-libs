//
// EvaluationResult.cs
//
// Author:
//       Lluis Sanchez <lluis@xamarin.com>
//
// Copyright (c) 2013 Xamarin Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using Mono.Debugging.Client;

namespace Mono.Debugging.Backend
{
    [Serializable]
    public class EvaluationResult
    {
        public EvaluationResult(string value, StringPresentationKind kind)
            : this(value, null, kind)
        {
            Value = value;
        }

        public EvaluationResult(string value, string displayValue)
            : this(value, displayValue, StringPresentationKind.Raw)
        {
            Value = value;
            DisplayValue = displayValue;
        }

        public EvaluationResult(
            string value,
            string displayValue = null,
            StringPresentationKind kind = StringPresentationKind.Raw,
            string additionalInfo = null)
        {
            Value = value;
            DisplayValue = displayValue ?? value;
            Kind = kind;
            AdditionalInfo = additionalInfo;
        }

        public string Value { get; private set; }
        public string DisplayValue { get; private set; }
        public StringPresentationKind Kind { get; }
        public string AdditionalInfo { get; }

        public override string ToString()
        {
            return Value;
        }
    }
}

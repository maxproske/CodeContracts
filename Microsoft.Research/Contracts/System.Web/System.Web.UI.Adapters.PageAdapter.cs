// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

// File System.Web.UI.Adapters.PageAdapter.cs
// Automatically generated contract file.
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics.Contracts;
using System;

// Disable the "this variable is not used" warning as every field would imply it.
#pragma warning disable 0414
// Disable the "this variable is never assigned to".
#pragma warning disable 0649
// Disable the "this variable is never used".
#pragma warning disable 0169
// Disable the "new keyword not required" warning.
#pragma warning disable 0109
// Disable the "extern without DllImport" warning.
#pragma warning disable 0626
// Disable the "could hide other member" warning, can happen on certain properties.
#pragma warning disable 0108


namespace System.Web.UI.Adapters
{
  abstract public partial class PageAdapter : ControlAdapter
  {
    #region Methods and constructors
    public virtual new System.Collections.Specialized.NameValueCollection DeterminePostBackMode ()
    {
      return default(System.Collections.Specialized.NameValueCollection);
    }

    protected internal virtual new string GetPostBackFormReference (string formId)
    {
      return default(string);
    }

    public virtual new System.Collections.ICollection GetRadioButtonsByGroup (string groupName)
    {
      return default(System.Collections.ICollection);
    }

    public virtual new System.Web.UI.PageStatePersister GetStatePersister ()
    {
      return default(System.Web.UI.PageStatePersister);
    }

    protected PageAdapter ()
    {
    }

    public virtual new void RegisterRadioButton (System.Web.UI.WebControls.RadioButton radioButton)
    {
      Contract.Requires (radioButton != null);
    }

    public virtual new void RenderBeginHyperlink (System.Web.UI.HtmlTextWriter writer, string targetUrl, bool encodeUrl, string softkeyLabel, string accessKey)
    {
      Contract.Requires (writer != null);
    }

    public virtual new void RenderBeginHyperlink (System.Web.UI.HtmlTextWriter writer, string targetUrl, bool encodeUrl, string softkeyLabel)
    {
    }

    public virtual new void RenderEndHyperlink (System.Web.UI.HtmlTextWriter writer)
    {
      Contract.Requires (writer != null);
    }

    public virtual new void RenderPostBackEvent (System.Web.UI.HtmlTextWriter writer, string target, string argument, string softkeyLabel, string text)
    {
    }

    public virtual new void RenderPostBackEvent (System.Web.UI.HtmlTextWriter writer, string target, string argument, string softkeyLabel, string text, string postUrl, string accessKey)
    {
    }

    protected void RenderPostBackEvent (System.Web.UI.HtmlTextWriter writer, string target, string argument, string softkeyLabel, string text, string postUrl, string accessKey, bool encode)
    {
      Contract.Requires (writer != null);
    }

    public virtual new string TransformText (string text)
    {
      return default(string);
    }
    #endregion

    #region Properties and indexers
    public virtual new System.Collections.Specialized.StringCollection CacheVaryByHeaders
    {
      get
      {
        return default(System.Collections.Specialized.StringCollection);
      }
    }

    public virtual new System.Collections.Specialized.StringCollection CacheVaryByParams
    {
      get
      {
        return default(System.Collections.Specialized.StringCollection);
      }
    }

    protected string ClientState
    {
      get
      {
        return default(string);
      }
    }
    #endregion
  }
}
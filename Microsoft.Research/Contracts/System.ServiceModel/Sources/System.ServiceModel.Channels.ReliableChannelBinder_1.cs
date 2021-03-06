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

// File System.ServiceModel.Channels.ReliableChannelBinder_1.cs
// Automatically generated contract file.
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics.Contracts;
using System;

// Disable the "this variable is not used" warning as every field would imply it.
#pragma warning disable 0414
// Disable the "this variable is never assigned to".
#pragma warning disable 0067
// Disable the "this event is never assigned to".
#pragma warning disable 0649
// Disable the "this variable is never used".
#pragma warning disable 0169
// Disable the "new keyword not required" warning.
#pragma warning disable 0109
// Disable the "extern without DllImport" warning.
#pragma warning disable 0626
// Disable the "could hide other member" warning, can happen on certain properties.
#pragma warning disable 0108


namespace System.ServiceModel.Channels
{
  abstract internal partial class ReliableChannelBinder<TChannel> : IReliableChannelBinder
  {
    #region Methods and constructors
    public void Abort()
    {
    }

    public IAsyncResult BeginClose(TimeSpan timeout, AsyncCallback callback, Object state)
    {
      return default(IAsyncResult);
    }

    public IAsyncResult BeginOpen(TimeSpan timeout, AsyncCallback callback, Object state)
    {
      return default(IAsyncResult);
    }

    public IAsyncResult BeginSend(Message message, TimeSpan timeout, AsyncCallback callback, Object state)
    {
      return default(IAsyncResult);
    }

    public virtual new IAsyncResult BeginTryReceive(TimeSpan timeout, AsyncCallback callback, Object state)
    {
      return default(IAsyncResult);
    }

    public void Close(TimeSpan timeout)
    {
    }

    public void EndClose(IAsyncResult result)
    {
    }

    public void EndOpen(IAsyncResult result)
    {
    }

    public void EndSend(IAsyncResult result)
    {
    }

    public virtual new bool EndTryReceive(IAsyncResult result, out RequestContext requestContext)
    {
      requestContext = default(RequestContext);

      return default(bool);
    }

    public abstract ISession GetInnerSession();

    public void HandleException(Exception e)
    {
    }

    public bool IsHandleable(Exception e)
    {
      return default(bool);
    }

    public void Open(TimeSpan timeout)
    {
    }

    internal ReliableChannelBinder()
    {
    }

    public void Send(Message message, TimeSpan timeout)
    {
    }

    public virtual new bool TryReceive(TimeSpan timeout, out RequestContext requestContext)
    {
      requestContext = default(RequestContext);

      return default(bool);
    }

    public RequestContext WrapRequestContext(RequestContext context)
    {
      return default(RequestContext);
    }
    #endregion

    #region Properties and indexers
    public abstract bool CanSendAsynchronously
    {
      get;
    }

    public IChannel Channel
    {
      get
      {
        return default(IChannel);
      }
    }

    public bool Connected
    {
      get
      {
        return default(bool);
      }
    }

    public TimeSpan DefaultSendTimeout
    {
      get
      {
        return default(TimeSpan);
      }
    }

    public abstract bool HasSession
    {
      get;
    }

    public abstract System.ServiceModel.EndpointAddress LocalAddress
    {
      get;
    }

    public abstract System.ServiceModel.EndpointAddress RemoteAddress
    {
      get;
    }

    public System.ServiceModel.CommunicationState State
    {
      get
      {
        return default(System.ServiceModel.CommunicationState);
      }
    }
    #endregion
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.HelpDesk.TypeRequest;

namespace DirRX.HelpDesk.Client
{
  partial class TypeRequestActions
  {
    public virtual void LinkDocument(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      
    }

    public virtual bool CanLinkDocument(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return true;
    }

  }

}
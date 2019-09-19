﻿using Autodesk.Revit.DB;
using System.Windows.Forms;

namespace JumpToPosition
{
  class JumpToPosition
  {
    public JumpToPosition( 
      Autodesk.Revit.DB.View view, 
      IWin32Window h )
    {
      Document doc = view.Document;

      JumpForm form = new JumpForm();

      DialogResult rslt = form.ShowDialog( h );

      if( DialogResult.OK == rslt )
      {
        using( Transaction tx = new Transaction( doc ) )
        {
          tx.Start( "Jump to Position" );
          tx.Commit();
        }
      }
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Object = Java.Lang.Object;

namespace Com.Firebase.Client.Snapshot
{
    public partial class ChildrenNode 
    {
        public int CompareTo(Object another)
        {
            return CompareTo((INode)another);
        }
    }
}
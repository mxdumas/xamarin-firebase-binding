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
    public partial class BooleanNode
    {
        protected override int CompareLeafValues(Object p0)
        {
            return CompareLeafValues((BooleanNode)p0);
        }

        public override int CompareTo(Object another)
        {
            return CompareTo((INode)another);
        }

        public override INode UpdatePriority(INode p0)
        {
            return UpdatePriorityInternal(p0);
        }
    }
}
using System;
using Android.Runtime;
using Java.Util;
using Object = Java.Lang.Object;

namespace Com.Firebase.Client.Snapshot 
{
    public partial class ChildrenNode
    {
        public partial class NamedNodeIterator
        {
            Object IIterator.Next()
            {
                return Next();
            }
        }
    }
}
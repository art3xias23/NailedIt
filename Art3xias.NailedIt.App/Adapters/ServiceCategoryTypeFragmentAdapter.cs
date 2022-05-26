using System;
using System.Collections.Generic;
using Android.Runtime;
using Android.Support.V4.App;
using Art3xias.NailedIt.App.Fragments;
using Art3xias.NailedIt.Core.Models;
using Java.Util;
using FragmentManager = Android.Support.V4.App.FragmentManager;

namespace Art3xias.NailedIt.App.Adapters
{
    internal class ServiceCategoryTypeFragmentAdapter : FragmentPagerAdapter
    {
        private List<ServiceCategoryType> _serviceTypes;

        public override int Count => _serviceTypes.Count;

        public override Fragment GetItem(int position)
        {
            ServiceCategoryTypeFragment serviceTypeFragment = new ServiceCategoryTypeFragment(_serviceTypes[position]);
            return serviceTypeFragment;
        }


        public ServiceCategoryTypeFragmentAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public ServiceCategoryTypeFragmentAdapter(FragmentManager fm) : base(fm)
        {
        }

    }
}
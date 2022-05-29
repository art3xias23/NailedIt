using System.Collections.Generic;
using Android.Support.V4.App;
using Art3xias.NailedIt.App.Fragments;
using Art3xias.NailedIt.Core;
using Art3xias.NailedIt.Core.Models;
using FragmentManager = Android.Support.V4.App.FragmentManager;

namespace Art3xias.NailedIt.App.Adapters
{
    internal class ServiceCategoryFragmentAdapter : FragmentPagerAdapter
    {
        private List<ServiceCategory> _serviceCategories;

        public override int Count => _serviceCategories.Count;

        public override Fragment GetItem(int position)
        {
            ServiceCategoryFragment serviceTypeFragment = new ServiceCategoryFragment(_serviceCategories[position]);
            return serviceTypeFragment;
        }

        public ServiceCategoryFragmentAdapter(FragmentManager fm) : base(fm)
        {
            var serviceTypeRepository = new ServiceTypeDummyRepository();
            _serviceCategories = serviceTypeRepository.GetCategoriesWithServices();
        }

        public override Java.Lang.ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(_serviceCategories[position].ServiceCategoryName);
        }

    }
}
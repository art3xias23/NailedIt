using System;
using Android.Content;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Art3xias.NailedIt.App.Adapters;
using Art3xias.NailedIt.Core.Models;

namespace Art3xias.NailedIt.App.Fragments
{
    internal class ServiceCategoryTypeFragment : Android.Support.V4.App.Fragment
    {
        private readonly ServiceCategoryType _serviceCategoryType;

        public ServiceCategoryTypeFragment(ServiceCategoryType serviceCategoryType)
        {
            _serviceCategoryType = serviceCategoryType;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.service_menu_fragment, container, false);

            var serviceTypeTextView = view.FindViewById<TextView>(Resource.Id.serviceTypeTextView);
            serviceTypeTextView.Text = _serviceCategoryType.ServiceCategoryTypeName;

            var serviceTypeRecyclerView = view.FindViewById<RecyclerView>(Resource.Id.serviceTypeMenuRecyclerView);

            var serviceTypeLayoutManager = new LinearLayoutManager(this.Context);

            var serviceTypeAdapter = new ServiceTypeAdapter(_serviceCategoryType);

            serviceTypeAdapter.ItemClick += ServiceTypeAdapter_ItemClick;
            serviceTypeRecyclerView.SetAdapter(serviceTypeAdapter);
        }

        private void ServiceTypeAdapter_ItemClick(object sender, int e)
        {
            var intent = new Intent();
            intent.SetClass(this.Context, typeof(ServiceTypeActivity));
            intent.PutExtra("selectedServiceTypeId", e);
            StartActivity(intent);
        }
    }
}
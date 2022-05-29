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
    internal class ServiceCategoryFragment : Android.Support.V4.App.Fragment
    {
        private readonly ServiceCategory _serviceCategory;

        public ServiceCategoryFragment(ServiceCategory serviceCategory)
        {
            _serviceCategory = serviceCategory;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.service_fragment, container, false);

            using (var serviceTypeTextView = view.FindViewById<TextView>(Resource.Id.serviceTextView))
            {
                serviceTypeTextView.Text = _serviceCategory.ServiceCategoryName;
            }

            var serviceRecyclerView = view.FindViewById<RecyclerView>(Resource.Id.serviceRecyclerView);

            var serviceTypeLayoutManager = new LinearLayoutManager(this.Context);

            serviceRecyclerView.SetLayoutManager(serviceTypeLayoutManager);

            var serviceAdapter = new ServiceAdapter(_serviceCategory);

            serviceAdapter.ItemClick += ServiceTypeAdapter_ItemClick;
            serviceRecyclerView.SetAdapter(serviceAdapter);

            return view;
        }

        private void ServiceTypeAdapter_ItemClick(object sender, int e)
        {
            var intent = new Intent();
            intent.SetClass(this.Context, typeof(ServiceActivity));
            intent.PutExtra("selectedServiceId", e);
            StartActivity(intent);
        }
    }
}
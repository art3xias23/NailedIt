using System;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using Art3xias.NailedIt.App.ViewHolders;
using Art3xias.NailedIt.Core;
using Art3xias.NailedIt.Core.Models;

namespace Art3xias.NailedIt.App.Adapters
{
    internal class ServiceTypeAdapter : RecyclerView.Adapter
    {
        private List<ServiceType> _serviceTypes;
        private ServiceTypeDummyRepository _serviceTypeRepository;
        public event EventHandler<int> ItemClick;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            if (holder is ServiceTypeViewHolder serviceTypeViewHolder)
            {
                serviceTypeViewHolder.ServiceTypeTextView.Text = _serviceTypes[position].ServiceTypeName;
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context)
                .Inflate(Resource.Layout.serviceType_viewholder, parent, false);

            ServiceTypeViewHolder serviceTypeViewHolder = new ServiceTypeViewHolder(itemView, Listener);

            return serviceTypeViewHolder;
        }

        public ServiceTypeAdapter(ServiceCategoryType serviceCategoryType)
        {
            _serviceTypes = serviceCategoryType.ServiceTypes;
        }

        public override int ItemCount { get; }

        public void Listener(int position)
        {
            var pieClickedId = _serviceTypes[position].ServiceTypeId;
            ItemClick?.Invoke(this, pieClickedId);
        }
    }
}
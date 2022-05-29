using System;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using Art3xias.NailedIt.App.ViewHolders;
using Art3xias.NailedIt.Core;
using Art3xias.NailedIt.Core.Models;

namespace Art3xias.NailedIt.App.Adapters
{
    internal class ServiceAdapter : RecyclerView.Adapter
    {
        private List<Service> _serviceTypes;
        private ServiceTypeDummyRepository _serviceTypeRepository;
        public event EventHandler<int> ItemClick;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            if (holder is ServiceViewHolder serviceViewHolder)
            {
                serviceViewHolder._serviceTextView.Text = _serviceTypes[position].ServiceTypeName;
                serviceViewHolder._servicePriceTextView.Text = _serviceTypes[position].ServiceCategoryType.ServiceCategoryName;
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context)
                .Inflate(Resource.Layout.service_viewholder, parent, false);

            ServiceViewHolder serviceTypeViewHolder = new ServiceViewHolder(itemView, Listener);

            return serviceTypeViewHolder;
        }

        public ServiceAdapter(ServiceCategory serviceCategoryType)
        {
            _serviceTypes = serviceCategoryType.Services;
        }

        public override int ItemCount => _serviceTypes.Count;
        public void Listener(int position)
        {
            var selectedServiceId = _serviceTypes[position].ServiceTypeId;
            ItemClick?.Invoke(this, selectedServiceId);
        }
    }
}
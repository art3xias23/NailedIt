using System;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace Art3xias.NailedIt.App.ViewHolders
{
    internal class ServiceViewHolder : RecyclerView.ViewHolder
    {
        public TextView _serviceTextView { get; set; }
        public TextView _servicePriceTextView { get; set; }
        private Action<int> _listener;

        public ServiceViewHolder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public ServiceViewHolder(View itemView, Action<int> listener) : base(itemView)
        {
            _serviceTextView = itemView.FindViewById<TextView>(Resource.Id.serviceTextView);
            _servicePriceTextView = itemView.FindViewById<TextView>(Resource.Id.servicePriceTextView);

            itemView.Click += ItemViewClick;
            _listener = listener;
        }

        private void ItemViewClick(object sender, EventArgs e)
        {
            _listener(base.LayoutPosition);
        }
    }
}
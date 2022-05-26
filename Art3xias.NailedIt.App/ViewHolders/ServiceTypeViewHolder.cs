using System;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace Art3xias.NailedIt.App.ViewHolders
{
    internal class ServiceTypeViewHolder : RecyclerView.ViewHolder
    {
        public TextView ServiceTypeTextView { get; set; }
        private Action<int> _listener;

        public ServiceTypeViewHolder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public ServiceTypeViewHolder(View itemView, Action<int> listener) : base(itemView)
        {
            ServiceTypeTextView = itemView.FindViewById<TextView>(Resource.Id.serviceTypeTextView);

            itemView.Click += ItemViewClick;
        }

        private void ItemViewClick(object sender, EventArgs e)
        {
            _listener(base.LayoutPosition);
        }
    }
}
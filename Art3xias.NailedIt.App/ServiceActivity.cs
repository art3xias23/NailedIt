using System;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Art3xias.NailedIt.Core;
using Art3xias.NailedIt.Core.Models;

namespace Art3xias.NailedIt.App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class ServiceActivity : AppCompatActivity
    {
        private ServiceTypeDummyRepository _serviceTypeRepository;
        private Core.Models.Service _selectedService;

        private TextView _serviceTypeNameTextView;
        private TextView _serviceTypePriceTextView;
        private Button _addToCartButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.service);

            _serviceTypeRepository = new ServiceTypeDummyRepository();

            _selectedService = _serviceTypeRepository.GetServiceTypeById(Intent.Extras.GetInt("selectedServiceId"));

            FindViews();

            BindData();
            LinkEventHandlers();
        }

        private void LinkEventHandlers()
        {
            _addToCartButton.Click += AddToCartButton_Click;
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {

            _serviceTypeRepository.AddToShoppingCart(_selectedService);
            Toast.MakeText(Application.Context, "Pie added to cart", ToastLength.Long).Show();

            this.Finish();
        }

        private void BindData()
        {
            _serviceTypeNameTextView.Text = _selectedService.ServiceTypeName;
            _serviceTypePriceTextView.Text = "Price: " + _selectedService.Price;
        }

        private void FindViews()
        {
            _serviceTypeNameTextView = FindViewById<TextView>(Resource.Id.serviceTypeTextView);
            _serviceTypePriceTextView = FindViewById<TextView>(Resource.Id.serviceTypePriceTextView);
            _addToCartButton = FindViewById<Button>(Resource.Id.addToCartButton);
        }
    }
}
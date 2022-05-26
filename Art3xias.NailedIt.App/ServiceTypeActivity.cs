using System;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Art3xias.NailedIt.Core;
using Art3xias.NailedIt.Core.Models;

namespace Art3xias.NailedIt.App
{
    internal class ServiceTypeActivity : AppCompatActivity
    {
        private ServiceTypeDummyRepository _serviceTypeRepository;
        private ServiceType _selectedService;

        private TextView _serviceTypeNameTextView;
        private TextView _serviceTypePriceTextView;
        private Button _addToCartButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.serviceType);

            _serviceTypeRepository = new ServiceTypeDummyRepository();

            _selectedService = _serviceTypeRepository.GetServiceTypeById(Intent.Extras.GetInt("selectedPieId"));

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
            var amount = int.Parse(_amountEditText.Text);

            ShoppingCartRepository shoppingCartRepository = new ShoppingCartRepository();
            _serviceTypeRepository.AddToShoppingCart(_selectedPie, amount);
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
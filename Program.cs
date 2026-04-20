namespace ThePremiumCalculatorv1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string headingBorder = "=====================================================";
			string divider = "-----------------------------------------------------";
			string dashboardTitle = "          SureGuard Insurance | Client Quote";
			string banner = "    Thank you for choosing SureGuard Insurance";
			string clientName = "Thabo Nkosi";
			string clientIdNumber = "9506015800083";
			int clientAge = 29;

			double vehicleValue = 450000.00;
			double vehiclePremiumRate = 0.0025;

			double homeValue = 1200000.00;
			double homePremiumRate = 0.0005;

			double coverAmount = 2000000.00;
			double lifePremiumRate = 0.0003;

			double vatRate = 0.15;

			//Vehicle Premium Calculation
			double vehiclePremium = vehicleValue * vehiclePremiumRate;
			double vehiclePremiumVAT = vehiclePremium * vatRate;
			double totalVehiclePayable = vehiclePremium + vehiclePremiumVAT;

			//Home Premium Calculation
			double homePremium = homeValue * homePremiumRate;
			double homePremiumVAT = homePremium * vatRate;
			double totalHomePayable = homePremium + homePremiumVAT;

			//Life Premium Calculation
			double lifePremium = coverAmount * lifePremiumRate;
			double lifePremiumVAT = lifePremium * vatRate;
			double totalLifePayable = lifePremium + lifePremiumVAT;

			double totalMonthlyPayable = totalVehiclePayable + totalHomePayable + totalLifePayable;

			//Output
			Console.WriteLine(headingBorder);
			Console.WriteLine(dashboardTitle);
			Console.WriteLine(headingBorder);
			Console.WriteLine($"Client:              {clientName}");
			Console.WriteLine($"Age:                 {clientAge}");
			Console.WriteLine($"ID Number:           {clientIdNumber}");

			Console.WriteLine();
			Console.WriteLine(divider);
			Console.WriteLine("PRODUCT 1: Vehicle Insurance");
			Console.WriteLine($"Vehicle Value:       R {vehicleValue:F2}");
			Console.WriteLine($"Monthly Premium:     R {vehiclePremium:F2}");
			Console.WriteLine($"VAT (15%):           R {vehiclePremiumVAT:F2}");
			Console.WriteLine($"Total Payable:       R {totalVehiclePayable:F2}");

			Console.WriteLine();
			Console.WriteLine(divider);
			Console.WriteLine("PRODUCT 2: Home Insurance");
			Console.WriteLine($"Home Value:          R {homeValue:F2}");
			Console.WriteLine($"Monthly Premium:     R {homePremium:F2}");
			Console.WriteLine($"VAT (15%):           R {homePremiumVAT:F2}");
			Console.WriteLine($"Total Payable:       R {totalHomePayable:F2}");

			Console.WriteLine();
			Console.WriteLine(divider);
			Console.WriteLine("PRODUCT 3: Life Insurance");
			Console.WriteLine($"Cover Amount:        R {coverAmount:F2}");
			Console.WriteLine($"Monthly Premium:     R {lifePremium:F2}");
			Console.WriteLine($"VAT (15%):           R {lifePremiumVAT:F2}");
			Console.WriteLine($"Total Payable:       R {totalLifePayable:F2}");

			Console.WriteLine(divider);
			Console.WriteLine();
			Console.WriteLine($"TOTAL MONTHLY PAYABLE: R {totalMonthlyPayable:F2}");

			Console.WriteLine(headingBorder);
			Console.WriteLine(banner);
			Console.WriteLine(headingBorder);



		}
	}
}

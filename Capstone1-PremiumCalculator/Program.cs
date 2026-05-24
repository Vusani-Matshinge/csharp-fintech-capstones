namespace TheInteractivePremiumCalculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string border = "=====================================================";
			string dashboardMessage = "       SureGuard | Vehicle Risk Assessment";
			string divider = "-----------------------------------------------------";

			string clientName;
			int clientAge,
				creditScore,
				yearsLicensed;
			double vehicleValue;

			double premiumRate = 0.0025;
			double riskAdjustmentRate = 0.05;
			double vatRate = 0.15;

			Console.Write("Please enter your full name: ");
			clientName = Console.ReadLine();

			Console.Write("Please enter your age: ");
			clientAge = Convert.ToInt32(Console.ReadLine());

			Console.Write("Please enter vehicle value: ");
			vehicleValue = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("PLease enter your credit score: ");
			creditScore = Convert.ToInt32(Console.ReadLine());

			int ageRiskPoints;
			string ageRiskLabel;

			if (clientAge < 25)
			{
				ageRiskPoints = 2;
				ageRiskLabel = "High";
			}
			else if (clientAge <= 35)
			{
				ageRiskPoints = 1;
				ageRiskLabel = "Medium";
			}
			else
			{
				ageRiskPoints = 0;
				ageRiskLabel = "Low";
			}

			int creditRiskPoints;
			string creditRiskLabel;

			if (creditScore < 600)
			{
				creditRiskPoints = 2;
				creditRiskLabel = "High";
			}
			else if (creditScore <= 700)
			{
				creditRiskPoints = 1;
				creditRiskLabel = "Medium";
			}
			else
			{
				creditRiskPoints = 0;
				creditRiskLabel = "Low";
			}

			int experienceRiskPoints;
			string experienceRiskLabel;

			if (yearsLicensed < 3)
			{
				experienceRiskPoints = 2;
				experienceRiskLabel = "High";
			}
			else if (yearsLicensed <= 5)
			{
				experienceRiskPoints = 1;
				experienceRiskLabel = "Medium";
			}
			else
			{
				experienceRiskPoints = 0;
				experienceRiskLabel = "Low";
			}

			int totalRiskScore = ageRiskPoints + creditRiskPoints + experienceRiskPoints;

			string riskCategory;

			if (totalRiskScore >= 4)
			{
				riskCategory = "High Risk";
			}
			else if (totalRiskScore >= 2)
			{
				riskCategory = "Medium Risk";
			}
			else
			{
				riskCategory = "Low Risk";
			}

			double premiumRate = 0.0025;
			double riskAdjustmentRate = 0.05;
			double vatRate = 0.15;

			double basePremium = vehicleValue * premiumRate;
			double riskAdjustment = basePremium * riskAdjustmentRate * totalRiskScore;
			double finalPremium = basePremium + riskAdjustment;
			double vat = finalPremium * vatRate;
			double totalPayable = finalPremium + vat;
		}
	}
}

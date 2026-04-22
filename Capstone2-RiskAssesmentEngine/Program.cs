using System;
using System.Globalization;

namespace TheRiskAssessmentEngine
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Raw client data from form
			string rawName = "Thabo Nkosi";
			string rawAge = "23";
			string rawVehicleValue = "320000.00";
			string rawCreditScore = "580";
			string rawYearsLicensed = "2";

			// ✅ FIX ADDED HERE
			string name = rawName;

			int age = Convert.ToInt32(rawAge);
			double vehicleValue = Convert.ToDouble(rawVehicleValue, CultureInfo.InvariantCulture);
			int creditScore = Convert.ToInt32(rawCreditScore);
			int yearsLicensed = Convert.ToInt32(rawYearsLicensed);

			int ageRiskPoints;
			string ageRiskLabel;

			if (age < 25)
			{
				ageRiskPoints = 2;
				ageRiskLabel = "High";
			}
			else if (age <= 35)
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

			Console.WriteLine("=====================================================");
			Console.WriteLine("        SureGuard | Vehicle Risk Assessment");
			Console.WriteLine("=====================================================");
			Console.WriteLine($"Client:           {name}");
			Console.WriteLine($"Age:              {age}");
			Console.WriteLine($"Vehicle Value:    R {vehicleValue:F2}");
			Console.WriteLine($"Credit Score:     {creditScore}");
			Console.WriteLine($"Years Licensed:   {yearsLicensed}");

			Console.WriteLine("\n-----------------------------------------------------");
			Console.WriteLine("RISK SCORING");
			Console.WriteLine("-----------------------------------------------------");
			Console.WriteLine($"Age Risk:         {ageRiskLabel,-8} (+{ageRiskPoints} points)");
			Console.WriteLine($"Credit Risk:      {creditRiskLabel,-8} (+{creditRiskPoints} points)");
			Console.WriteLine($"Experience Risk:  {experienceRiskLabel,-8} (+{experienceRiskPoints} points)");
			Console.WriteLine("-----------------------------------------------------");
			Console.WriteLine($"Total Risk Score: {totalRiskScore}");
			Console.WriteLine($"Risk Category:    {riskCategory}");

			Console.WriteLine("\n-----------------------------------------------------");
			Console.WriteLine("BASE PREMIUM");
			Console.WriteLine("-----------------------------------------------------");
			Console.WriteLine($"Base Premium:     R {basePremium:F2}");
			Console.WriteLine($"Risk Adjustment:  R {riskAdjustment:F2}");
			Console.WriteLine($"Final Premium:    R {finalPremium:F2}");
			Console.WriteLine($"VAT (15%):        R {vat:F2}");
			Console.WriteLine($"Total Payable:    R {totalPayable:F2}");
			Console.WriteLine("=====================================================");
		}
	}
}
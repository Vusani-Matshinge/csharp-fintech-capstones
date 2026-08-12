using System.Globalization;

namespace SureGuardInteractiveSystem
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int userChoice;

			// SureGuard Interactive System UI boilerplate code
			string sureguardFinacialSystemMenuBorder = "=====================================================";
			string sureguardFinancialSystemMenuOutline = "-----------------------------------------------------";
			string sureguardFinacialSystemMenuTitle = "         SureGuard Financial System v4";
			string sureGuardFinacialSystemVheicleInsuranceQoute = "          SureGuard | Vehicle Insurance Quote";
			string sureguardFinacialSystemRiskAssessmentReport = "          SureGuard | Risk Assessment Report";
			string sureguardFinacialSystemLoanAffordabilityCheckReport = "          SureGuard | Loan Affordability Report";

			// Repeat the menu until the user chooses 0
			do
			{
				Console.Clear();

				Console.WriteLine(sureguardFinacialSystemMenuBorder);
				Console.WriteLine(sureguardFinacialSystemMenuTitle);
				Console.WriteLine(sureguardFinacialSystemMenuBorder);

				Console.WriteLine("  [1]  New Client Quote");
				Console.WriteLine("  [2]  Risk Assessment");
				Console.WriteLine("  [3]  Loan Affordability Check");
				Console.WriteLine("  [0]  Exit");

				Console.WriteLine(sureguardFinacialSystemMenuBorder);

				Console.Write("Enter your choice: ");
				userChoice = Convert.ToInt32(Console.ReadLine());

				switch (userChoice)
				{
					case 1:
						// Handle New Client Quote

						Console.Write("Enter your name: ");
						string sureGuard1ClientName = Console.ReadLine();

						Console.Write("Enter your age: ");
						int sureGuard1ClientAge =
							Convert.ToInt32(Console.ReadLine());

						// Validate if user is 18 years and above
						while (sureGuard1ClientAge < 18)
						{
							Console.WriteLine(
								"Age must be 18 or above. Try again.");

							Console.Write("Enter your age: ");
							sureGuard1ClientAge =
								Convert.ToInt32(Console.ReadLine());
						}

						Console.Write("Enter your vehicle value: ");
						double sureGuard1ClientVehicleValue =
							Convert.ToDouble(
								Console.ReadLine(),
								CultureInfo.InvariantCulture);

						double sureGuardPremiumRate = 0.0025;
						double sureGuardAgeLoading = 0.20;
						double vatRate = 0.15;

						// Calculate base premium
						double sureGuardBasePremium =
							sureGuard1ClientVehicleValue *
							sureGuardPremiumRate;

						// Calculate age loading
						double sureGuardAgeLoadingAmount = 0;

						if (sureGuard1ClientAge < 25)
						{
							sureGuardAgeLoadingAmount =
								sureGuardBasePremium *
								sureGuardAgeLoading;
						}

						// Calculate final premium
						double sureGuardFinalPremium =
							sureGuardBasePremium +
							sureGuardAgeLoadingAmount;

						// Calculate VAT
						double vat =
							sureGuardFinalPremium *
							vatRate;

						// Calculate total payable
						double sureGuardTotalPayable =
							sureGuardFinalPremium +
							vat;

						// Display New Client Quote
						Console.WriteLine();
						Console.WriteLine(
							sureguardFinacialSystemMenuBorder);

						Console.WriteLine(
							sureGuardFinacialSystemVheicleInsuranceQoute);

						Console.WriteLine(
							sureguardFinacialSystemMenuBorder);

						Console.WriteLine(
							$"Client:          {sureGuard1ClientName}");

						Console.WriteLine(
							$"Age:             {sureGuard1ClientAge}");

						Console.WriteLine(
							$"Vehicle Value:   R {sureGuard1ClientVehicleValue:F2}");

						Console.WriteLine(
							$"Base Premium:    R {sureGuardBasePremium:F2}");

						Console.WriteLine(
							$"Age Loading:     R {sureGuardAgeLoadingAmount:F2}");

						Console.WriteLine(
							$"Final Premium:   R {sureGuardFinalPremium:F2}");

						Console.WriteLine(
							$"VAT (15%):       R {vat:F2}");

						Console.WriteLine(
							$"Total Payable:   R {sureGuardTotalPayable:F2}");

						Console.WriteLine(
							sureguardFinacialSystemMenuBorder);

						Console.WriteLine();
						Console.WriteLine(
							"Press ENTER to return to the main menu.");

						Console.ReadLine();

						break;


					case 2:
						// Handle Risk Assessment

						Console.Write("Enter your name: ");
						string sureGuard2ClientName = Console.ReadLine();

						Console.Write("Enter your age: ");
						int sureGuard2ClientAge =
							Convert.ToInt32(Console.ReadLine());

						while (sureGuard2ClientAge < 18)
						{
							Console.WriteLine(
								"Age must be 18 or above. Try again.");

							Console.Write("Enter your age: ");
							sureGuard2ClientAge =
								Convert.ToInt32(Console.ReadLine());
						}

						Console.Write("Enter your vehicle value: ");
						double sureGuard2ClientVehicleValue =
							Convert.ToDouble(
								Console.ReadLine(),
								CultureInfo.InvariantCulture);

						Console.Write("Enter credit score: ");
						int sureGuard2ClientCreditScore =
							Convert.ToInt32(Console.ReadLine());

						while (sureGuard2ClientCreditScore < 300 ||
							   sureGuard2ClientCreditScore > 850)
						{
							Console.WriteLine(
								"Credit score must be between 300 and 850. Try again.");

							Console.Write("Enter credit score: ");
							sureGuard2ClientCreditScore =
								Convert.ToInt32(Console.ReadLine());
						}

						Console.Write("Enter years licensed: ");
						int sureGuard2ClientYearsLicensed =
							Convert.ToInt32(Console.ReadLine());

						// Age risk
						int ageRisk2Points;
						string ageRisk2Label;

						if (sureGuard2ClientAge < 25)
						{
							ageRisk2Points = 2;
							ageRisk2Label = "High";
						}
						else if (sureGuard2ClientAge <= 35)
						{
							ageRisk2Points = 1;
							ageRisk2Label = "Medium";
						}
						else
						{
							ageRisk2Points = 0;
							ageRisk2Label = "Low";
						}

						// Experience risk
						int experienceRiskPoints;
						string experienceRiskLabel;

						if (sureGuard2ClientYearsLicensed < 3)
						{
							experienceRiskPoints = 2;
							experienceRiskLabel = "High";
						}
						else if (sureGuard2ClientYearsLicensed <= 5)
						{
							experienceRiskPoints = 1;
							experienceRiskLabel = "Medium";
						}
						else
						{
							experienceRiskPoints = 0;
							experienceRiskLabel = "Low";
						}

						// Credit risk
						int creditRiskPoints;
						string creditRiskLabel;

						if (sureGuard2ClientCreditScore < 600)
						{
							creditRiskPoints = 2;
							creditRiskLabel = "High";
						}
						else if (sureGuard2ClientCreditScore <= 700)
						{
							creditRiskPoints = 1;
							creditRiskLabel = "Medium";
						}
						else
						{
							creditRiskPoints = 0;
							creditRiskLabel = "Low";
						}

						// Calculate total risk score
						int sureGuardTotalRiskPoints =
							ageRisk2Points +
							creditRiskPoints +
							experienceRiskPoints;

						// Determine risk category
						string sureGuardRiskCategory;

						if (sureGuardTotalRiskPoints >= 4)
						{
							sureGuardRiskCategory = "High Risk";
						}
						else if (sureGuardTotalRiskPoints >= 2)
						{
							sureGuardRiskCategory = "Medium Risk";
						}
						else
						{
							sureGuardRiskCategory = "Low Risk";
						}

						double sureGuardPremiumRate2 = 0.0025;
						double sureGuardRiskAdjustmentRate = 0.05;
						double vatRate2 = 0.15;

						// Calculate base premium
						double sureGuardBasePremium2 =
							sureGuard2ClientVehicleValue *
							sureGuardPremiumRate2;

						// Calculate risk adjustment
						double sureGuardRiskAdjustmentAmount =
							sureGuardBasePremium2 *
							sureGuardRiskAdjustmentRate *
							sureGuardTotalRiskPoints;

						// Calculate final premium
						double sureGuardFinalPremium2 =
							sureGuardBasePremium2 +
							sureGuardRiskAdjustmentAmount;

						// Calculate VAT
						double vat2 =
							sureGuardFinalPremium2 *
							vatRate2;

						// Calculate total payable
						double sureGuardTotalPayable2 =
							sureGuardFinalPremium2 +
							vat2;

						// Display Risk Assessment Report
						Console.WriteLine();
						Console.WriteLine(
							sureguardFinacialSystemMenuBorder);

						Console.WriteLine(
							sureguardFinacialSystemRiskAssessmentReport);

						Console.WriteLine(
							sureguardFinacialSystemMenuBorder);

						Console.WriteLine(
							$"Client:           {sureGuard2ClientName}");

						Console.WriteLine(
							$"Age:              {sureGuard2ClientAge}");

						Console.WriteLine(
							$"Vehicle Value:    R {sureGuard2ClientVehicleValue:F2}");

						Console.WriteLine(
							$"Credit Score:     {sureGuard2ClientCreditScore}");

						Console.WriteLine(
							$"Years Licensed:   {sureGuard2ClientYearsLicensed}");

						Console.WriteLine(
							sureguardFinancialSystemMenuOutline);

						Console.WriteLine("RISK SCORING");

						Console.WriteLine(
							sureguardFinancialSystemMenuOutline);

						Console.WriteLine(
							$"Age Risk:         {ageRisk2Label,-8} (+{ageRisk2Points} points)");

						Console.WriteLine(
							$"Credit Risk:      {creditRiskLabel,-8} (+{creditRiskPoints} points)");

						Console.WriteLine(
							$"Experience Risk:  {experienceRiskLabel,-8} (+{experienceRiskPoints} points)");

						Console.WriteLine(
							sureguardFinancialSystemMenuOutline);

						Console.WriteLine(
							$"Total Risk Score: {sureGuardTotalRiskPoints}");

						Console.WriteLine(
							$"Risk Category:    {sureGuardRiskCategory}");

						Console.WriteLine(
							sureguardFinancialSystemMenuOutline);

						Console.WriteLine("BASE PREMIUM CALCULATION");

						Console.WriteLine(
							sureguardFinancialSystemMenuOutline);

						Console.WriteLine(
							$"Base Premium:     R {sureGuardBasePremium2:F2}");

						Console.WriteLine(
							$"Risk Adjustment:  R {sureGuardRiskAdjustmentAmount:F2}");

						Console.WriteLine(
							$"Final Premium:    R {sureGuardFinalPremium2:F2}");

						Console.WriteLine(
							$"VAT (15%):        R {vat2:F2}");

						Console.WriteLine(
							$"Total Payable:    R {sureGuardTotalPayable2:F2}");

						Console.WriteLine(
							sureguardFinacialSystemMenuBorder);

						Console.WriteLine();
						Console.WriteLine(
							"Press ENTER to return to the main menu.");

						Console.ReadLine();

						break;


					case 3:
						// Handle Loan Affordability Check

						Console.Write("Enter client name: ");
						string sureGuard3ClientName = Console.ReadLine();

						Console.Write("Enter your age: ");
						int sureGuard3ClientAge =
							Convert.ToInt32(Console.ReadLine());

						// Validate age
						while (sureGuard3ClientAge < 18)
						{
							Console.WriteLine(
								"Age must be 18 or above. Try again.");

							Console.Write("Enter your age: ");
							sureGuard3ClientAge =
								Convert.ToInt32(Console.ReadLine());
						}

						Console.Write("Enter annual salary: ");
						double sureGuard3ClientSalary =
							Convert.ToDouble(
								Console.ReadLine(),
								CultureInfo.InvariantCulture);

						Console.Write("Enter loan amount: ");
						double sureGuard3ClientLoanAmount =
							Convert.ToDouble(
								Console.ReadLine(),
								CultureInfo.InvariantCulture);

						// Credit score is a whole number
						Console.Write("Enter credit score: ");
						int sureGuard3ClientCreditScore =
							Convert.ToInt32(Console.ReadLine());

						// Validate credit score
						while (sureGuard3ClientCreditScore < 300 ||
							   sureGuard3ClientCreditScore > 850)
						{
							Console.WriteLine(
								"Credit score must be between 300 and 850. Try again.");

							Console.Write("Enter credit score: ");
							sureGuard3ClientCreditScore =
								Convert.ToInt32(Console.ReadLine());
						}

						// Calculate loan-to-salary ratio
						double sureGuard3LoanToSalary =
							sureGuard3ClientLoanAmount /
							sureGuard3ClientSalary;

						// Business rule checks
						bool sureGuard3AffordabilityCheck =
							sureGuard3LoanToSalary <= 5.0;

						bool sureGuard3CreditScoreCheck =
							sureGuard3ClientCreditScore >= 600;

						// Individual check statuses
						string sureGuard3AffordabilityStatus =
							sureGuard3AffordabilityCheck
								? "Passed"
								: "Failed";

						string sureGuard3CreditScoreStatus =
							sureGuard3CreditScoreCheck
								? "Passed"
								: "Failed";

						// Overall approval business rule
						bool sureGuard3ApprovalCheck =
							sureGuard3ClientAge >= 18 &&
							sureGuard3CreditScoreCheck &&
							sureGuard3AffordabilityCheck;

						// Determine final status once
						string sureGuard3Status =
							sureGuard3ApprovalCheck
								? "APPROVED"
								: "DECLINED";

						// Calculate monthly salary
						double sureGuard3MonthlySalary =
							sureGuard3ClientSalary / 12;

						// Display Loan Affordability Check Report
						Console.WriteLine();
						Console.WriteLine(
							sureguardFinacialSystemMenuBorder);

						Console.WriteLine(
							sureguardFinacialSystemLoanAffordabilityCheckReport);

						Console.WriteLine(
							sureguardFinacialSystemMenuBorder);

						Console.WriteLine(
							$"Client:          {sureGuard3ClientName}");

						Console.WriteLine(
							$"Annual Salary:   R {sureGuard3ClientSalary:F2}");

						Console.WriteLine(
							$"Monthly Salary:  R {sureGuard3MonthlySalary:F2}");

						Console.WriteLine(
							$"Loan Amount:     R {sureGuard3ClientLoanAmount:F2}");

						Console.WriteLine(
							$"Credit Score:    {sureGuard3ClientCreditScore}");

						Console.WriteLine(
							$"Loan-to-Salary:  {sureGuard3LoanToSalary:F2}");

						Console.WriteLine(
							sureguardFinancialSystemMenuOutline);

						Console.WriteLine("ASSESSMENT");

						Console.WriteLine(
							sureguardFinancialSystemMenuOutline);

						Console.WriteLine(
							$"Credit Check:    {sureGuard3CreditScoreStatus}");

						Console.WriteLine(
							$"Affordability:   {sureGuard3AffordabilityStatus}");

						Console.WriteLine(
							sureguardFinancialSystemMenuOutline);

						// Reuse the status calculated above
						Console.WriteLine(
							$"Status:          {sureGuard3Status}");

						Console.WriteLine(
							sureguardFinancialSystemMenuOutline);

						Console.WriteLine();
						Console.WriteLine(
							"Press ENTER to return to the main menu.");

						Console.ReadLine();

						break;


					case 0:
						// Exit condition
						Console.WriteLine();
						Console.WriteLine(
							"Thank you for using the SureGuard Financial System.");

						Console.WriteLine("Goodbye!");

						break;


					default:
						Console.WriteLine();
						Console.WriteLine(
							"Invalid option. Please select 0, 1, 2 or 3.");

						Console.WriteLine();
						Console.WriteLine(
							"Press ENTER to return to the main menu.");

						Console.ReadLine();

						break;
				}

			} while (userChoice != 0);
		}
	}
}
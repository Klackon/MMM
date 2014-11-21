//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;

public class City
{
	private string name, race;
	private int population;
	private int workers, farmers;
	private double taxRate;
	private int prodPoints;
	private string currentBuild;
	private int buildTime;

	public City (string n, string r, int pop, double tax)
	{
		name = n;
		race = r;
		population = pop;
		farmers = population / 2;
		workers = population - farmers;

		prodPoints = farmers + workers*2;
		if (race == "dwarves" || race == "klackons")
			prodPoints = prodPoints + workers;

		taxRate = 1;
		currentBuild = null;
		buildTime = 0;
	}

	public void workersToFarmers(int shiftAmount)
	{
		workers = workers - shiftAmount;
		farmers = farmers + shiftAmount;
	}

	public void farmersToWorkers(int shiftAmount)
	{
		if(farmers - shiftAmount >= population/2)
		{
			farmers = farmers - shiftAmount;
			workers = workers + shiftAmount;
		}
	}

	public void setPopulation(int pop)
	{
		population = pop;
		farmers = pop / 2;
		workers = pop - farmers;
	}

	public void setTaxRate(double tax)
	{
		taxRate = tax;
	}

	public void setProdPoints(int prod)
	{
		prodPoints = prod;
	}

	public void setBuildandTime(string build, int time)
	{
		currentBuild = build;
		buildTime = time;
	}

	public string getName()
	{
		return name;
	}

	public string getRace()
	{
		return race;
	}

	public int getPopulation()
	{
		return population;
	}

	public int getWorkers()
	{
		return workers;
	}

	public int getFarmers()
	{
		return farmers;
	}

	public double getTaxRate()
	{
		return taxRate;
	}

	public int getProdPoints()
	{
		return prodPoints;
	}














}



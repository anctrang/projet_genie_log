﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil
//     Les modifications apportées à ce fichier seront perdues si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Resultat
{
	private Participant participant
	{
		get;
		set;
	}

	private Course course
	{
		get;
		set;
	}

	private TimeSpan temps
	{
		get;
		set;
	}

	private double vitesseMoyenne
	{
		get;
		set;
	}

	private double allureMoyenne
	{
		get;
		set;
	}

	public virtual List<Course> Course
	{
		get;
		set;
	}

	public virtual List<Participant> Participant
	{
		get;
		set;
	}

}


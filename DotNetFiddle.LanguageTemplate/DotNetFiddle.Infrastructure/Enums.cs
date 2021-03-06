﻿using System;
using System.ComponentModel;

namespace DotNetFiddle.Infrastructure
{
	[Serializable]
	public enum Language
	{
		[Description("C#")] 
		CSharp = 1,
		[Description("VB.NET")] 
		VbNet,
		[Description("F#")]
		FSharp
	}

	[Serializable]
	public enum ProjectType
	{
		[Description("Console")]
		Console = 1,
		[Description("Script")]
		Script,
		[Description("MVC")]
		Mvc
	}

	[Serializable]
	public enum LimitType
	{
		ExecutionTime,
		MemoryUsage,
		CodeSize,
		CodeOutput,
		DirSize
	}

	[Serializable]
	public enum MvcViewEngine
	{
		[Description("Razor")]
		Razor,
		[Description("ASPX")]
		Aspx
	}

	[Serializable]
	public enum MvcFileType
	{
		[Description("Model")]
		Model,
		[Description("View")]
		View,
		[Description("Controller")]
		Controller
	}
}

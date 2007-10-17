// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Mike Krüger" email="mike@icsharpcode.net"/>
//     <version value="$version"/>
// </file>
using System;
using System.Collections;
using System.Reflection;

namespace MonoDevelop.Projects.Parser
{
	public interface IMember : IDecoration
	{
		string FullyQualifiedName {
			get;
		}
		IRegion Region {
			get;
		}

		IReturnType ReturnType {
			get;
		}

		IClass DeclaringType {
			get;
		}
		
		bool IsExplicitDeclaration {
			get;
		}
		IReturnType ExplicitDeclaration {
			get;
			set;
		}
	}
}

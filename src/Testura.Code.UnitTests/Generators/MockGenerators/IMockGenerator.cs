﻿using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Mono.Cecil;
using Testura.Code.Models;

namespace Testura.Code.UnitTests.MockGenerators
{
    public interface IMockGenerator
    {
        IList<Field> CreateFields(TypeDefinition typeUnderTest, IEnumerable<Models.Parameter> parameters);
        IList<StatementSyntax> GenerateSetUpStatements(TypeDefinition typeUnderTest, IEnumerable<Models.Parameter> parameters);
    }
}

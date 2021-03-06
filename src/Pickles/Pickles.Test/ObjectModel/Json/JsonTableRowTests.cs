﻿//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="JsonTableRowTests.cs" company="PicklesDoc">
//  Copyright 2011 Jeffrey Cameron
//  Copyright 2012-present PicklesDoc team and community contributors
//
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  </copyright>
//  --------------------------------------------------------------------------------------------------------------------

using NFluent;
using NUnit.Framework;
using PicklesDoc.Pickles.DocumentationBuilders.JSON;
using PicklesDoc.Pickles.ObjectModel;
using PicklesDoc.Pickles.TestFrameworks;

namespace PicklesDoc.Pickles.Test.ObjectModel.Json
{
    [TestFixture]
    public class JsonTableRowTests
    {
        [Test]
        public void TableRowWithCells_Always_ConvertsToJsonTableRow()
        {
            var tableRow = new TableRow { Cells = { "cell 1", "cell 2" } };

            var jsonMapper = new JsonMapper();

            JsonTableRow jsonTableRow = jsonMapper.Map(tableRow);

            Check.That(jsonTableRow).ContainsExactly("cell 1", "cell 2");
        }

        [Test]
        public void TableRowWithTestResult_Always_ConvertsToJsonTableRowWithTestResult()
        {
            var tableRow = new TableRow { Result = TestResult.Passed };

            var jsonMapper = new JsonMapper();

            JsonTableRow jsonTableRow = jsonMapper.Map(tableRow);

            Check.That(jsonTableRow.Result.WasExecuted).IsEqualTo(true);
            Check.That(jsonTableRow.Result.WasSuccessful).IsEqualTo(true);
        }
    }
}

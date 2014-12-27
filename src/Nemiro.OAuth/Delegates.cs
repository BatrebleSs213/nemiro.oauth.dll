﻿// ----------------------------------------------------------------------------
// Copyright (c) Aleksey Nemiro, 2014. All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nemiro.OAuth
{

  /// <summary>
  /// Represents a method that is called for parsing item of the <b>API</b> data.
  /// </summary>
  /// <param name="value">The <see cref="UniValue"/> instance to parse.</param>
  public delegate object CustomParse(UniValue value);

  /// <summary>
  /// References a method to be called when a corresponding asynchronous web request completes.
  /// </summary>
  /// <param name="result">The result of the asynchronous web request.</param>
  public delegate void ExecuteRequestAsyncCallback(RequestResult result);

}

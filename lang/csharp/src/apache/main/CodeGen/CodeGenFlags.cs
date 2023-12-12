/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace Avro
{
    /// <summary>
    /// Flags used by codegen to control code generation.
    /// </summary>
    [Flags]
    public enum CodeGenFlags
    {
        /// <summary>
        /// No flags.
        /// </summary>
        None = 0x0000,

        /// <summary>
        /// Skip creating directories for generated files.
        /// </summary>
        SkipDirectoryCreation = 0x0001,

        /// <summary>
        /// Keep original namespace in schema.
        /// </summary>
        KeepOriginalNamespaceInSchema = 0x0002,

        /// <summary>
        /// Generate PascalCase record properties.
        /// </summary>
        PascalCaseRecordProperties = 0x0004
    }
}

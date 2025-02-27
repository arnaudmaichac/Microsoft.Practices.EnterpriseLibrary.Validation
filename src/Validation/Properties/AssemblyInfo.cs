﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design;
using Microsoft.Practices.EnterpriseLibrary.Validation.Configuration;
using System.Runtime.InteropServices;
using System.Security;

[assembly: SecurityTransparent]

[assembly: ComVisible(false)]

[assembly: HandlesSection(ValidationSettings.SectionName)]
[assembly: AddApplicationBlockCommand(
                ValidationSettings.SectionName,
                typeof(ValidationSettings),
                TitleResourceType = typeof(DesignResources),
                TitleResourceName = "AddValidationSettings")]

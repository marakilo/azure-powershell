﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;

namespace Microsoft.Azure.Commands.AzureBackup.Test.ScenarioTests
{
    public class AzureBackupTests : AzureBackupTestsBase
    {
        [Fact]
        public void ListProtectionPolicyTests()
        {
            this.RunPowerShellTest("Test-GetAzureBackupProtectionPolicyTests");
        }

        [Fact]
        public void ListAzureBackupItemTests()
        {
            this.RunPowerShellTest("Test-GetAzureBackupItemTests");
        }

        [Fact]
        public void EnableDisableAzureBackupProtectionTest()
        {
            this.RunPowerShellTest("Test-EnableDisableAzureBackupProtectionTest");
        }

        [Fact]

        public void GetAzureBackupJobTests()
        {
            this.RunPowerShellTest("Test-GetAzureBackupJob");
        }

        [Fact]
        public void StopAzureBackupJobTests()
        {
            this.RunPowerShellTest("Test-StopAzureBackupJob");
        }
        public void GetRecoveryPointTests()
        {
            this.RunPowerShellTest("GetAzureRecoveryPointTest");
        }

        [Fact]
        public void BackUpAzureBackUpItem()
        {
            this.RunPowerShellTest("BackUpAzureBackUpItemTest");
        }

        [Fact]
        public void GetAzureBackupContainerTests()
        {
            this.RunPowerShellTest("Test-GetAzureBackupContainerWithoutFilterReturnsNonZeroContainers");

            this.RunPowerShellTest("Test-GetAzureBackupContainerWithUniqueFilterReturnsOneContainer");
        }

        [Fact]
        public void GetAzureBackupVaultCredentialsTests()
        {
            this.RunPowerShellTest("Test-GetAzureBackupVaultCredentialsReturnsFileNameAndDownloadsCert");
        }

        [Fact]
        public void SetAzureBackupVaultStorageTypeTests()
        {
            this.RunPowerShellTest("Test-SetAzureBackupVaultStorageTypeWithFreshResourceDoesNotThrowException");

            this.RunPowerShellTest("Test-SetAzureBackupVaultStorageTypeWithLockedResourceThrowsException");
        }
    }
}

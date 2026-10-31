terraform {
  required_version = ">=1.4.0"

  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = ">=4.0"
    }
  }
  
  backend "azurerm" {
    resource_group_name  = "AZ-Storage-RSG"
    storage_account_name = "azstoragecontainer"
    container_name       = "tfstate"
    key                  = "aks.terraform"

  }
}

provider "azurerm" {
  features {}
  subscription_id = "16d60876-2016-4013-9895-cc00224e539c"
}   
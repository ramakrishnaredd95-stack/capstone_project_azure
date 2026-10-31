output "aks_cluster_name" {
    value = azurerm_kubernetes_cluster.flipkartaks1.name
  
}
output "resource_group_name" {
    value = azurerm_resource_group.flipkartrg.name
  
}
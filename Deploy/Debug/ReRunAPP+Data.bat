cd ../../
dotnet build Oxygen-Dapr.EshopSample.sln
PowerShell -Command "kubectl delete po $(kubectl get po -n infrastructure  -o jsonpath='{.items[0].metadata.name}') -n infrastructure"
PowerShell -Command "kubectl delete po $(kubectl get po -n infrastructure  -o jsonpath='{.items[1].metadata.name}') -n infrastructure"
PowerShell -Command "kubectl delete po $(kubectl get po -n infrastructure  -o jsonpath='{.items[2].metadata.name}') -n infrastructure"
PowerShell -Command "kubectl delete po $(kubectl get po -n dapreshop  -o jsonpath='{.items[0].metadata.name}') -n dapreshop"
PowerShell -Command "kubectl delete po $(kubectl get po -n dapreshop  -o jsonpath='{.items[1].metadata.name}') -n dapreshop"
PowerShell -Command "kubectl get po -n dapreshop -w"
$sourceversion=$args[0]
$files=$(git diff-tree --no-commit-id --name-only -r $sourceversion)
$temp=$files -split ' '
$count=$temp.Length
echo "Total changed $count files"
For ($i=0; $i -lt $temp.Length; $i++){
    $name=$temp[$i]
    if ($name -like '*yml'){
        if($name -notlike 'azure-pipeline.yml'){
            Write-Host '##vso[task.setvariable variable=yamlFileName;]'$name
        }
    }
}
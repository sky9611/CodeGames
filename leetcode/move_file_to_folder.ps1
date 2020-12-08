$files = Get-ChildItem -file | Where-Object {$_.basename -match '\.'}
ForEach ($file in $files)
{
    $index,$qn = $file.Name -split "\.";
    $folderName = "[" + $index + "] " + $qn;
    $folder = New-Item -Type Directory -name $folderName
    Move-Item $file $folder
}
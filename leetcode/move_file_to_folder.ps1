$files = Get-ChildItem -file | Where-Object {$_.basename -match '\.'}
ForEach ($file in $files)
{
    $index,$qn = $file.basename -split "\.";
    $folderExisted = Get-ChildItem -Directory | Where-Object {$_.BaseName -match '\['+$index+'\]'}
    if($folderExisted -is [System.IO.DirectoryInfo])
    {
        Move-Item $file $folderExisted[0]
    }
    else
    {
        $folderName = "[" + $index + "] " + $qn;
        $folder = New-Item -Type Directory -name $folderName
        Move-Item $file $folder
    }
}
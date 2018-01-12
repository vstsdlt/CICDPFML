Param(
  [string]$pathToSearch = $env:BUILD_SOURCESDIRECTORY,
  [string]$buildNumber = $env:BUILD_BUILDNUMBER,
  [string]$searchFilter = "AssemblyInfo.*",
  [regex]$pattern = "\d+\.\d+\.\d+\.\d+"
)
  
if ($buildNumber -match $pattern -ne $true) {
    Write-Error "Could not extract a version from [$buildNumber] using pattern [$pattern]"
    exit 1
} else {
    try {
        $extractedBuildNumber = $Matches[0]
        Write-Host "Using version $extractedBuildNumber in folder $pathToSearch"
  
        $files = gci -Path $pathToSearch -Filter $searchFilter -Recurse
 
        if ($files){
            $files | % {
                $fileToChange = $_.FullName  
                Write-Host "  -> Changing $($fileToChange)"
                 
                # remove the read-only bit on the file
                sp $fileToChange IsReadOnly $false
  
                # run the regex replace
                (gc $fileToChange) | % { $_ -replace $pattern, $extractedBuildNumber } | sc $fileToChange
            }
        } else {
            Write-Warning "No files found"
        }
  
        Write-Host "Done!"
        exit 0
    } catch {
        Write-Error $_
        exit 1
    }
}

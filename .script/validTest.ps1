function IsFailed{
   param(
     [string[]]$testInfo
   )


    $failed = ($test | Select-String -Pattern 'Failed!')
    
    return  ($failed.Matches.Length -ne 0)
}


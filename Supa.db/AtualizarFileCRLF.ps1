## Alterar Arquivo - CRLF / LF

Get-ChildItem -Path ".\Supa.db" -Filter *.sh -Recurse | ForEach-Object {
    (Get-Content -Raw -Path $_.FullName) -replace "`r`n", "`n" | Set-Content -NoNewline -Path $_.FullName
    Write-Host "Arquivo ajustado: $($_.FullName)"
}
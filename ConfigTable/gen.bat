set WORKSPACE=..\Assets

set GEN_CLIENT=.\luban\luban_examples-main\Tools\Luban\Luban.dll
set CONF_ROOT=.

dotnet %GEN_CLIENT% ^
    -t client ^
    -c cs-simple-json ^
    -d json ^
    --conf %CONF_ROOT%\luban.conf ^
    -x outputCodeDir=%WORKSPACE%\Luban\GenCode ^
    -x outputDataDir=%WORKSPACE%\Luban\GenerateDatas\json

pause
# msbuild Pseudo-Locale Repro

A repro for not being able to compile satellite resource assemblies for Windows' [pseudo-locales](https://docs.microsoft.com/en-gb/windows/desktop/Intl/pseudo-locales) using MSBuild.

To replicate:

```ps
git clone https://github.com/martincostello/msbuild-pseudo-locale-repro.git
cd ./msbuild-pseudo-locale-repro/PseudoLocales
dotnet run -- qps-ploc
```

## Expected output

```ps
[Héllö?? wörlð¡??]
[Sá??rd?? !!!]
```

## Actual output

```ps
Hello world!
[Sá??rd?? !!!]
```

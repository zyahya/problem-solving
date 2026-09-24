Other possible solutions:

```cs
// Old syntax but most compatible
return sheeps.Count(s => s);
```

```cs
MemoryExtensions.Count(sheeps.AsSpan(), true);
```

# AI Agent Instructions

## Purpose

Use this guide when asked to configure the visual appearance of blocks that represent C-Code functions.

## Scope of configuration

The chapter describes configuration options for C function arguments in CCodeConfig.xml.

The examples are intentionally minimal and organized in two groups:

1. Port location variants
2. Flag behavior examples

## Visual appearance controls

### 1) Port location variants

Port location controls where an argument port appears on the block.

Default behavior:

- All arguments are displayed as input ports on the left.

Supported variants shown in the chapter:

- TOP
- LEFT
- BOTTOM
- INVISIBLE

Example configuration patterns:

```xml
<function name="portTop" imageURI="images/ETAS_Logo_Blue.png" >
    <argument index="0" name="in" portLocation="TOP"/>
</function>
```

```xml
<function name="portLeft" imageURI="images/ETAS_Logo_Blue.png" >
    <argument index="0" name="in" portLocation="LEFT"/>
</function>
```

```xml
<function name="portBottom" imageURI="images/ETAS_Logo_Blue.png" >
    <argument index="0" name="in" portLocation="BOTTOM"/>
</function>
```

```xml
<function name="portInvisible" imageURI="images/ETAS_Logo_Blue.png" >
    <argument index="0" name="in" portLocation="INVISIBLE"/>
</function>
```

Expected outcome to preserve:

- The same one-port function can appear with different port placements.
- INVISIBLE hides the port from the block interface.

### 2) Flag behavior examples

Semantics documented in the chapter:

- isInstance="true": the argument is used as instance name of the block, i.e. below the block.
- isReference="true": the argument is passed as reference.

Example configuration patterns:

```xml
<function name="instanceName" imageURI="images/ETAS_Logo_Blue.png" >
    <argument index="0" name="instanceId" isInstance="true"/>
</function>
```

```xml
<function name="referenceArg" imageURI="images/ETAS_Logo_Blue.png" >
    <argument index="0" name="refValue" isReference="true"/>
</function>
```

```xml
<function name="instanceReference" imageURI="images/ETAS_Logo_Blue.png" >
    <argument index="0" name="instanceRef" isInstance="true" isReference="true"/>
</function>
```

Expected outcome to preserve:

- isInstance=true changes how the argument is used for block instance naming.
- isReference=true marks the argument as reference-passed.
- The combined example shows both behaviors at once.

## Required editing rules for agents

When modifying or generating these examples:

1. Keep terminology exactly as documented: TOP, LEFT, BOTTOM, INVISIBLE, isInstance, isReference.
2. Keep examples minimal with one argument to isolate behavior.
3. Keep the chapter structure: without configuration vs with configuration.
4. Do not introduce additional attributes or concepts not present in the chapter.
5. Keep XML snippets aligned with the chapter patterns (function with argument index, name, and the relevant attribute).

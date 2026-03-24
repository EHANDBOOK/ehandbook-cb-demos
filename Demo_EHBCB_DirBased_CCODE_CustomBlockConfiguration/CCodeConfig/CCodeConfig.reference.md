# CCodeConfig.xml Reference

This document is a comprehensive reference for:

- `Demo_EHBCB_DirBased_CCODE_ConfigExample/CCodeConfig/CCodeConfig.xml`

It explains the XML structure, element attributes, configured function metadata, and the extension points prepared in the file.

## Contents

1. Purpose
2. Root Element and Namespaces
3. `globalConfiguration`
4. Element Model
5. Configured Functions
6. Prepared Extension Sections (Currently Empty/Commented)
7. Pattern Cheat Sheet
8. Customization Guidelines
9. Quick Reference Snippets
10. Comprehensive Examples
11. File Location

---

## 1. Purpose

`CCodeConfig.xml` provides a set of customizable configurations that influence how C-Code implementations are graphically visualized as interactive models and embedded graphics. It is used by the Unified Graphics Generator (UGG) and EHANDBOOK Container-Build (EHB-CB).

It controls:

- Global processing behavior (`globalConfiguration`)
- Function visualization metadata (icon/image, name matching)
- Function argument metadata (name, index, port placement, instance/reference semantics)
- Optional mapping and filtering hooks (currently present as commented templates)

### Using a C-Code Configuration File

The C-code configuration file defines how EHANDBOOK Container-Build interprets and processes C source code during documentation generation.

### Specifying the Configuration File

Provide the configuration file with the `-ccodemeta` command-line option.

Command syntax:

```text
-ccodemeta "path/to/configuration.xml"
```

This configuration mechanism enables you to:

- configure shared library paths
- control diagram simplification
- enable function inlining
- generate hierarchical structures

---

## 2. Root Element and Namespaces

```xml
<functionmetadata:FunctionMetadataRoot
  xmi:version="2.0"
  xmlns:functionmetadata="http://www.etas.com/ehandbook/functionmetadata"
  xmlns:xmi="http://www.omg.org/XMI">
```

### Attributes

| Attribute | Value | Meaning |
| --------- | ----- | ------- |
| `xmi:version` | `2.0` | XMI version used by the metadata format. |
| `xmlns:functionmetadata` | `http://www.etas.com/ehandbook/functionmetadata` | Namespace for function metadata elements. |
| `xmlns:xmi` | `http://www.omg.org/XMI` | XMI namespace declaration. |

---

## 3. `globalConfiguration`

The `globalConfiguration` element defines the high-level behavior EHANDBOOK Container-Build uses when analyzing and visualizing C code.

```xml
<globalConfiguration
  libraryPath="../lib"
  inlineFunctions="true"
  simplifyDiagram="true"
  generateHierarchies="false"
  maxIterationForDataflowAnalysis="50000"/>
```

This is the `globalConfiguration` currently used in this example project. Additional supported parameters can also be defined when needed.

| Attribute                         | Value    | Description                                                    |
| --------------------------------- | -------- | -------------------------------------------------------------- |
| `libraryPath`                     | `../lib` | Relative path to the C code library used by the configuration. |
| `inlineFunctions`                 | `true`   | Enables function inlining behavior.                            |
| `simplifyDiagram`                 | `true`   | Enables simplification of generated diagrams.                  |
| `generateHierarchies`             | `false`  | Disables hierarchy generation.                                 |
| `maxIterationForDataflowAnalysis` | `50000`  | Iteration limit for dataflow analysis convergence.             |
| `shouldReplaceReferenceArguments` | optional | Controls how reference (pointer / by-reference) arguments are handled during inlining. When set to `false`, the inliner replaces only additional or non-essential reference arguments that would otherwise clutter the generated model. |

### Parameter Details

#### `libraryPath`

Specifies the directory containing external shared libraries. This enables EHB-CB to resolve functions or symbols not present in the main source files during analysis.

#### `inlineFunctions`

When set to `true`, smaller or wrapper functions are replaced with their implementation body in diagrams. This creates simpler visualizations by eliminating unnecessary function calls and clarifying control flow.

#### `simplifyDiagram`

Removes unnecessary nodes, unused ports, and intermediate blocks from control and data flow diagrams. This produces cleaner, more compact visualizations that are easier to read.

#### `generateHierarchies`

Generates hierarchical diagrams instead of flat views. Functions are organized into logical levels such as function, sub-function, and sub-sub-function.

#### `shouldReplaceReferenceArguments`

Controls how reference arguments are handled during inlining. When disabled, only additional or non-essential reference arguments are replaced, which helps keep the generated model readable without changing semantics.

### Sample Minimal Configuration File

The following sample shows the minimal structure of a C-code configuration file with only the root element and `globalConfiguration`.

```xml
<functionmetadata:FunctionMetadataRoot
    xmlns:functionmetadata="http://www.etas.com/ehandbook/functionmetadata"
    xmlns:xmi="http://www.omg.org/XMI"
    xmi:version="2.0">

    <globalConfiguration
        libraryPath="../lib"
        inlineFunctions="true"
        simplifyDiagram="true"
        generateHierarchies="true"/>

</functionmetadata:FunctionMetadataRoot>
```

In this project, `generateHierarchies` is currently set to `false`, but the sample above shows a valid alternative configuration where hierarchy generation is enabled.

---

## 4. Element Model

## 4.1 `function`

A `function` element configures metadata for one function name or a name pattern.

Common attributes used in this file:

| Attribute     | Required | Description                                      |
| ------------- | -------- | ------------------------------------------------ |
| `name`        | Yes      | Literal function name or regex-style pattern.    |
| `imageURI`    | No       | Relative path to image/icon used for display.    |
| `comment`     | No       | Human-readable description.                      |
| `unifiedName` | No       | Canonical name used to unify displayed identity. |
| `operator`    | No       | Operator mapping (shown in commented template).  |

### Matching behavior

- Literal names are used for exact matches (for example `GetMember`, `SrvB_Limit`).
- Regex-style names are used for pattern matching (for example `DT1_.*`, `PID(_.*)?`).

## 4.2 `argument`

An `argument` element configures one input/port of a matched function.

Attributes used in this file:

| Attribute      | Description                                                       |
| -------------- | ----------------------------------------------------------------- |
| `index`        | Zero-based argument position in function call signature.          |
| `name`         | Display/semantic name of the argument.                            |
| `portLocation` | Visual placement hint (observed values: `LEFT`, `TOP`, `BOTTOM`). |
| `isInstance`   | Marks argument as an instance/context object (`true`/`false`).    |
| `isReference`  | Marks argument as reference-like (`true`/`false`).                |

Notes:

- Some `argument` entries omit `index`. In those cases, the engine may infer ordering from declaration order.
- `isInstance` and `isReference` are only specified for some functions where this distinction is important.

---

## 5. Configured Functions

.# 5.1 Basic Function Definitions
.These define common low-level operations and explicit port layouts..
| Name/Pattern    | Image                      | Comment            .                          | Arguments                                                            .|
| --------------- | -------------------------- | --------------------------------------------- | --------------------------------------------------------------------- |
| `GetMember`     | `images/GetMember.png`     | get a member of a struct or union             | `0: base (BOTTOM)`                                                    |
| `GetAddr`       | `images/GetAddressOf.png`  | get the address of a variable                 | `0: base (LEFT)`                                                      |
| `GetIndexDeref` | `images/GetIndexDeref.png` | get the value of an array at position 'index' | `0: base (BOTTOM)`, `1: index (BOTTOM)`                               |
| `GetDeref`      | `images/GetDeref.png`      | get the value stored at a pointer's address   | `0: base (LEFT)`                                                      |
| `SetMember`     | `images/SetMember.png`     | set a member of a struct or union             | `0: base (BOTTOM)`, `1: value (LEFT)`                                 |
| `SetDeref`      | `images/SetDeref.png`      | set the value at a pointer's address          | `0: base (BOTTOM)`, `1: value (LEFT)`                                 |
| `SetIndexDeref` | `images/SetIndexDeref.png` | set the value of an array at position 'index' | `0: base (BOTTOM)`, `1: index (BOTTOM)`, `2: value (LEFT)`            |

## 5.2 Flex_ECU Specific Function Definitions

| Name/Pattern         | Image                         | Notes                                                                  | Arguments                                                                                                                             |
| -------------------- | ----------------------------- | ---------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- |
| `COUNTER(E)?(E)?_.*` | `images/CounterE.png`         | Matches `COUNTER...` variants with optional `E`/`EE` and suffix.       | none defined                                                                                                                          |
| `DT1_.*_compute`     | `images/DT1.png`              | Specialized compute variant with explicit argument mapping.            | `0: in (LEFT, isInstance=false, isReference=false)`, `1: Ta (TOP, false/false)`, `2: K (TOP, false/false)`, `3: T (TOP, false/false)` |
| `DT1_.*`             | `images/DT1.png`              | Generic DT1 pattern fallback.                                          | none defined                                                                                                                          |
| `EDGEFALLING(_.*)?`  | `images/SrvB_EdgeFalling.png` | Matches `EDGEFALLING` optionally followed by `_...`.                   | none defined                                                                                                                          |
| `EDGERISING(_.*)?`   | `images/SrvB_EdgeRising.png`  | Matches `EDGERISING` optionally followed by `_...`.                    | none defined                                                                                                                          |
| `PID(_.*)?`          | `images/PID.bmp`              | Matches `PID` and `PID_...`.                                           | none defined                                                                                                                          |
| `RSF(F.*)?`          | `images/SrvB_RSFF.png`        | Matches `RSF` and `RSFF...` variants.                                  | none defined                                                                                                                          |
| `SrvB_Limit`         | `images/Srv_Limit.png`        | Uses `unifiedName="Srv_Limit"` for canonical representation.           | `0: x (LEFT, false/false)`, `1: min (TOP, false/false)`, `2: max (TOP, false/false)`                                                  |
| `CharTable1.*`       | `images/curve.png`            | Curve function family.                                                 | `curve_data (BOTTOM, isInstance=true, isReference=true)`, `input (LEFT)`                                                              |
| `CharTable2.*`       | `images/map.png`              | Map function family.                                                   | `map_data (BOTTOM, isInstance=true, isReference=true)`, `input1 (LEFT)`, `input2 (LEFT)`                                              |
| `Hysteresis.*`       | `images/hysteresis.png`       | Hysteresis family pattern.                                             | none defined                                                                                                                          |

---

## 6. Prepared Extension Sections (Currently Empty/Commented)

The file intentionally includes placeholders for project-specific customization.

## 6.1 Customer Specific Function Definition

Section exists and is currently empty:

```xml
<!--START : Customer Specific Function Definition -->

<!--END : Customer Specific Function Definition -->
```

Use this area to add additional `<function ...>` entries for customer-specific APIs.

## 6.2 Customer Specific Function to Operator Mapping

Template present (commented):

```xml
<!--<function name="(SRV_)?ABS_.*" operator="ABS"/>-->
```

Use this to map matched function names to a known operator abstraction.

## 6.3 Ignorable Macros

Template present (commented):

```xml
<!--<ignorableMacro regexp="ACCUMULATOR_[US].*"/>-->
```

Use this to define macro patterns that should not be resolved.

## 6.4 Included FCs (Force Inlining/Including)

Template present (commented):

```xml
<!--<includedFC name="ABKGEL"/>-->
```

Use this list to include specific FCs explicitly.

---

## 7. Pattern Cheat Sheet

Examples from this file:

- `.*` → any suffix/content
- `(_.*)?` → optional underscore + suffix
- `(E)?(E)?` → optional `E`, and another optional `E` (allowing none, `E`, or `EE`)

Practical interpretation examples:

- `PID(_.*)?` matches `PID`, `PID_X`, `PID_Controller`
- `EDGEFALLING(_.*)?` matches `EDGEFALLING`, `EDGEFALLING_FOO`
- `DT1_.*_compute` matches names like `DT1_Filter_compute_V2`

---

## 8. Customization Guidelines

- Keep broad patterns after specific ones where overlap is possible (for example, `DT1_.*_compute` before `DT1_.*`).
- Reuse the existing `images/` folder for new symbols to keep rendering consistent.
- Prefer explicit `argument` metadata for important blocks to improve readability of generated diagrams.
- Use `unifiedName` when multiple implementation-specific names should be shown as one conceptual block.

---

## 9. Quick Reference Snippets

### Add a custom function with explicit argument layout

```xml
<function name="MyBlock_.*" imageURI="images/MyBlock.png" comment="My custom block">
  <argument index="0" name="u" portLocation="LEFT"/>
  <argument index="1" name="k" portLocation="TOP"/>
</function>
```

### Add an operator mapping

```xml
<function name="MYABS_.*" operator="ABS"/>
```

### Add ignorable macro pattern

```xml
<ignorableMacro regexp="MY_INTERNAL_MACRO_.*"/>
```

### Add included FC

```xml
<includedFC name="MY_FUNCTION_CLASS"/>
```

## 10. Comprehensive Examples

This section provides larger, practical examples that show how the different configuration elements can be used together.

### 10.1 Exact function match

Use an exact name when only one concrete function should receive the metadata.

```xml
<function name="SrvB_Saturation" imageURI="images/Srv_Limit.png" comment="Saturation block">
  <argument index="0" name="x" portLocation="LEFT"/>
  <argument index="1" name="min" portLocation="TOP"/>
  <argument index="2" name="max" portLocation="TOP"/>
</function>
```

What this does:

- Matches only `SrvB_Saturation`
- Assigns a dedicated image
- Defines readable argument names and port positions

### 10.2 Regex-based function family

Use a pattern when many related functions should share the same visualization.

```xml
<function name="Filter1_.*" imageURI="images/DT1.png" comment="1st order filter family">
  <argument index="0" name="in" portLocation="LEFT"/>
  <argument index="1" name="timeConstant" portLocation="TOP"/>
</function>
```

Example matches:

- `Filter1_Main`
- `Filter1_VehicleSpeed`
- `Filter1_TempComp`

### 10.3 Specific pattern before generic pattern

When two patterns overlap, place the more specific definition first.

```xml
<function name="Filter1_.*_compute" imageURI="images/DT1.png" comment="Compute variant">
  <argument index="0" name="in" portLocation="LEFT"/>
  <argument index="1" name="state" portLocation="BOTTOM"/>
</function>

<function name="Filter1_.*" imageURI="images/DT1.png" comment="Generic filter family"/>
```

Why this matters:

- `Filter1_.*_compute` is a subset of `Filter1_.*`
- Placing the specific entry first preserves the detailed argument layout for compute variants

### 10.4 Using `unifiedName` for implementation variants

Use `unifiedName` when several implementation-specific function names should appear as one conceptual block.

```xml
<function name="SrvB_Limit_u8" imageURI="images/Srv_Limit.png" unifiedName="Srv_Limit">
  <argument index="0" name="x" portLocation="LEFT"/>
  <argument index="1" name="min" portLocation="TOP"/>
  <argument index="2" name="max" portLocation="TOP"/>
</function>

<function name="SrvB_Limit_s16" imageURI="images/Srv_Limit.png" unifiedName="Srv_Limit">
  <argument index="0" name="x" portLocation="LEFT"/>
  <argument index="1" name="min" portLocation="TOP"/>
  <argument index="2" name="max" portLocation="TOP"/>
</function>
```

This is useful when different data-type variants should be represented uniformly.

### 10.5 Instance/reference arguments for table-like blocks

Use `isInstance="true"` and `isReference="true"` when an argument represents referenced block data or table data.

```xml
<function name="CharTable1_AirMass" imageURI="images/curve.png" comment="Air mass curve">
  <argument name="curve_data" portLocation="BOTTOM" isInstance="true" isReference="true"/>
  <argument name="input" portLocation="LEFT"/>
</function>
```

Typical interpretation:

- `curve_data` is the referenced characteristic data set
- `input` is the runtime input signal

### 10.6 Operator mapping example

Use operator mapping when a function should be treated like a known mathematical or logical operator.

```xml
<function name="(SRV_)?ABS_.*" operator="ABS"/>
```

Example matches:

- `ABS_Value`
- `SRV_ABS_Filtered`

### 10.7 Ignorable macro example

Use `ignorableMacro` to exclude macros that are implementation details and should not be expanded.

```xml
<ignorableMacro regexp="ACCUMULATOR_[US].*"/>
<ignorableMacro regexp="DBG_.*"/>
<ignorableMacro regexp="INTERNAL_HELPER_.*"/>
```

Good candidates:

- compiler abstraction macros
- debug-only helper macros
- internal accumulator or wrapper macros

### 10.8 Included FC example

Use `includedFC` when a specific function class should always be included or inlined according to the processing rules.

```xml
<includedFC name="ABKGEL"/>
<includedFC name="TORQUE_PATH"/>
<includedFC name="AIR_SYSTEM"/>
```

### 10.9 Customer-specific section example

The following example shows how the prepared customization sections can look when populated.

```xml
<!--START : Customer Specific Function Definition -->
<function name="Cust_RateLimiter" imageURI="images/Srv_Limit.png" comment="Customer-specific rate limiter">
  <argument index="0" name="in" portLocation="LEFT"/>
  <argument index="1" name="rise" portLocation="TOP"/>
  <argument index="2" name="fall" portLocation="TOP"/>
</function>

<function name="Cust_Map2D_.*" imageURI="images/map.png" comment="Customer-specific 2D map family">
  <argument name="map_data" portLocation="BOTTOM" isInstance="true" isReference="true"/>
  <argument name="x" portLocation="LEFT"/>
  <argument name="y" portLocation="LEFT"/>
</function>
<!--END : Customer Specific Function Definition -->

<!--START : Customer Specific Function to Operator Mapping -->
<function name="Cust_ABS_.*" operator="ABS"/>
<!--END : Customer Specific Function to Operator Mapping -->

<!--START : List of macros that shall not be resolved -->
<ignorableMacro regexp="CUST_INTERNAL_.*"/>
<!--END : List of macros that shall not be resolved -->

<!--START : List of FCs that shall be inlined -->
<includedFC name="CUST_SIGNAL_PATH"/>
<!--END : List of FCs that shall be inlined -->
```

### 10.10 Commented example with inline explanations

```xml
<!-- Match all functions that start with Cust_Filter_ -->
<function name="Cust_Filter_.*" imageURI="images/DT1.png" comment="Customer filter family">
  <!-- Main input signal -->
  <argument index="0" name="in" portLocation="LEFT"/>

  <!-- Calibration parameter shown on top -->
  <argument index="1" name="K" portLocation="TOP"/>

  <!-- Time constant shown on top -->
  <argument index="2" name="T" portLocation="TOP"/>
</function>
```

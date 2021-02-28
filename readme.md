what is known about the data file so far
- all is uncompressed
- file listing is at the bottom
- `00000008` points to this file listing
- `00000004` counts amount of files

```
Offset(h) 00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F
                                                                         v start of file info chunk
C4B5DCD0  00 00 FE FF 7F 3F 01 00 80 3F 00 00 00 00 74 78  ..þÿ.?..€?....tx
C4B5DCE0  74 72 31 2E 75 74 5F 73 74 61 72 74 5F 67 6F 5F  tr1.ut_start_go_
C4B5DCF0  63 6E 00 00 00 00 99 01 00 00 28 01 00 00 16 00  cn....™...(.....
C4B5DD00  00 00 31 00 00 00 14 00 00 00 90 FD 12 00 0C 0C  ..1........ý....
C4B5DD10  81 7C D9 07 00 00 88 FD 12 00 D9 07 0B 00 58 2A  .|Ù...ˆý..Ù...X*
C4B5DD20  0A 00 00 00 00 00 42 D8 70 01 00 00 00 00 80 0F  ......BØp.....€.
C4B5DD30  E9 E8 54 5F CA 01 96 AA 90 06 A8 FD 12 00 74 78  éèT_Ê.–ª..¨ý..tx 0x60 bytes long
C4B5DD40  74 72 31 2E 68 74 5F 6C 6F 67 6F 52 61 77 5F 73  tr1.ht_logoRaw_s
C4B5DD50  6D 61 6C 6C 00 00 99 01 00 00 03 02 00 00 27 00  mall..™.......'.
C4B5DD60  00 00 32 00 00 00 14 00 00 00 90 FD 12 00 0C 0C  ..2........ý....
C4B5DD70  81 7C D9 07 00 00 88 FD 12 00 D9 07 0B 00 9C 40  .|Ù...ˆý..Ù...œ@
C4B5DD80  00 00 00 00 00 00 26 C8 CF 0B 00 00 00 00 B0 BE  ......&ÈÏ.....°¾
C4B5DD90  EF 16 55 5F CA 01 3A 84 1F 00 A8 FD 12 00 64 61  ï.U_Ê.:„..¨ý..da
C4B5DDA0  74 61 2E 74 72 61 6E 73 6C 61 74 65 30 5F 63 6E  ta.translate0_cn
C4B5DDB0  00 00 00 00 00 00 99 01 00 00 03 02 00 00 1A 00  ......™.........
C4B5DDC0  00 00 33 00 00 00 14 00 00 00 90 FD 12 00 0C 0C  ..3........ý....
C4B5DDD0  81 7C D9 07 00 00 88 FD 12 00 D9 07 0B 00 44 2F  .|Ù...ˆý..Ù...D/
C4B5DDE0  00 00 00 00 00 00 01 3B 3C 1E 00 00 00 00 30 60  .......;<.....0`
C4B5DDF0  F3 32 55 5F CA 01 8E C1 09 00 A8 FD 12 00 74 78  ó2U_Ê.ŽÁ..¨ý..tx
C4B5DE00  74 72 31 2E 77 74 5F 63 6F 6E 63 65 70 74 5F 6C  tr1.wt_concept_l
C4B5DE10  76 6C 5F 32 38 5F 63 6E 00 00 9C 00 00 00 29 00  vl_28_cn..œ...).
C4B5DE20  00 00 33 00 00 00 14 00 00 00 90 FD 12 00 0C 0C  ..3........ý....
C4B5DE30  81 7C D9 07 00 00 88 FD 12 00 D9 07 0B 00 9C 00  .|Ù...ˆý..Ù...œ.
C4B5DE40  04 00 00 00 00 00 FB 12 7A 1F 00 00 00 00 40 6A  ......û.z.....@j
C4B5DE50  AD 3B 55 5F CA 01 27 B2 AB 02 A8 FD 12 00 74 78  .;U_Ê.'²«.¨ý..tx
C4B5DE60  74 72 31 2E 77 74 5F 63 6F 6E 63 65 70 74 5F 6C  tr1.wt_concept_l
C4B5DE70  76 6C 5F 33 39 5F 63 6E 00 00 86 01 00 00 2E 00  vl_39_cn..†.....
C4B5DE80  00 00 33 00 00 00 14 00 00 00 90 FD 12 00 0C 0C  ..3........ý....
C4B5DE90  81 7C D9 07 00 00 88 FD 12 00 D9 07 0B 00 9C 00  .|Ù...ˆý..Ù...œ.
C4B5DEA0  04 00 00 00 00 00 63 20 D2 1F 00 00 00 00 60 0F  ......c Ò.....`.
C4B5DEB0  CC 3E 55 5F CA 01 74 3B AD 02 A8 FD 12 00 74 78  Ì>U_Ê.t;..¨ý..tx
C4B5DEC0  74 72 31 2E 77 74 5F 72 6F 67 75 65 5F 6C 76 6C  tr1.wt_rogue_lvl
C4B5DED0  5F 30 36 5F 63 6E 00 01 00 00 7D 00 00 00 09 00  _06_cn....}.....
C4B5DEE0  00 00 35 00 00 00 14 00 00 00 90 FD 12 00 0C 0C  ..5........ý....
C4B5DEF0  81 7C D9 07 00 00 88 FD 12 00 D9 07 0B 00 9C 00  .|Ù...ˆý..Ù...œ.
```

## todos:

* figure out what allows for longer file name
* figure out literally everything else

## credits:

Jon D. Jackson for DDS reader

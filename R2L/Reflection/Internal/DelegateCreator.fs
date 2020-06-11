namespace rec R2L.Reflection.Internal
// Turn back now if you value your sanity
// You have been warned
// Mostly placeholder until I have time to figure out type providers
open System

type internal FuncDelC<'TRet> = delegate of Unit -> 'TRet
type internal FuncDelC<'T1, 'TRet> = delegate of 'T1 -> 'TRet
type internal FuncDelC<'T1, 'T2, 'TRet> = delegate of 'T1 * 'T2 -> 'TRet
type internal FuncDelC<'T1, 'T2, 'T3, 'TRet> = delegate of 'T1 * 'T2 * 'T3 -> 'TRet
type internal FuncDelC<'T1, 'T2, 'T3, 'T4, 'TRet> = delegate of 'T1 * 'T2 * 'T3 * 'T4 -> 'TRet
type internal FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'TRet> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 -> 'TRet
type internal FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 -> 'TRet
type internal FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 -> 'TRet
type internal FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 -> 'TRet
type internal FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 -> 'TRet
type internal FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 -> 'TRet
type internal FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 -> 'TRet
type internal FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 -> 'TRet
type internal FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 -> 'TRet
type internal FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 -> 'TRet
type internal FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15 -> 'TRet
type internal FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15 * 'T16 -> 'TRet
type internal FuncDelT<'TRet> = delegate of (Unit) -> 'TRet
type internal FuncDelT<'T1, 'TRet> = delegate of ('T1) -> 'TRet
type internal FuncDelT<'T1, 'T2, 'TRet> = delegate of ('T1 * 'T2) -> 'TRet
type internal FuncDelT<'T1, 'T2, 'T3, 'TRet> = delegate of ('T1 * 'T2 * 'T3) -> 'TRet
type internal FuncDelT<'T1, 'T2, 'T3, 'T4, 'TRet> = delegate of ('T1 * 'T2 * 'T3 * 'T4) -> 'TRet
type internal FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'TRet> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5) -> 'TRet
type internal FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6) -> 'TRet
type internal FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7) -> 'TRet
type internal FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8) -> 'TRet
type internal FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9) -> 'TRet
type internal FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10) -> 'TRet
type internal FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11) -> 'TRet
type internal FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12) -> 'TRet
type internal FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13) -> 'TRet
type internal FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14) -> 'TRet
type internal FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15) -> 'TRet
type internal FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15 * 'T16) -> 'TRet
type internal ActDelC = delegate of Unit -> Unit
type internal ActDelC<'T1> = delegate of 'T1 -> Unit
type internal ActDelC<'T1, 'T2> = delegate of 'T1 * 'T2 -> Unit
type internal ActDelC<'T1, 'T2, 'T3> = delegate of 'T1 * 'T2 * 'T3 -> Unit
type internal ActDelC<'T1, 'T2, 'T3, 'T4> = delegate of 'T1 * 'T2 * 'T3 * 'T4 -> Unit
type internal ActDelC<'T1, 'T2, 'T3, 'T4, 'T5> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 -> Unit
type internal ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 -> Unit
type internal ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 -> Unit
type internal ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 -> Unit
type internal ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 -> Unit
type internal ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 -> Unit
type internal ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 -> Unit
type internal ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 -> Unit
type internal ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 -> Unit
type internal ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 -> Unit
type internal ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15 -> Unit
type internal ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16> = delegate of 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15 * 'T16 -> Unit
type internal ActDelT = delegate of (Unit) -> Unit
type internal ActDelT<'T1> = delegate of ('T1) -> Unit
type internal ActDelT<'T1, 'T2> = delegate of ('T1 * 'T2) -> Unit
type internal ActDelT<'T1, 'T2, 'T3> = delegate of ('T1 * 'T2 * 'T3) -> Unit
type internal ActDelT<'T1, 'T2, 'T3, 'T4> = delegate of ('T1 * 'T2 * 'T3 * 'T4) -> Unit
type internal ActDelT<'T1, 'T2, 'T3, 'T4, 'T5> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5) -> Unit
type internal ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6) -> Unit
type internal ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7) -> Unit
type internal ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8) -> Unit
type internal ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9) -> Unit
type internal ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10) -> Unit
type internal ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11) -> Unit
type internal ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12) -> Unit
type internal ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13) -> Unit
type internal ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14) -> Unit
type internal ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15) -> Unit
type internal ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16> = delegate of ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15 * 'T16) -> Unit
type internal InstFuncDelC<'TInst, 'TRet> = delegate of 'TInst -> 'TRet
type internal InstFuncDelC<'TInst, 'T1, 'TRet> = delegate of 'TInst * 'T1 -> 'TRet
type internal InstFuncDelC<'TInst, 'T1, 'T2, 'TRet> = delegate of 'TInst * 'T1 * 'T2 -> 'TRet
type internal InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'TRet> = delegate of 'TInst * 'T1 * 'T2 * 'T3 -> 'TRet
type internal InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'TRet> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 -> 'TRet
type internal InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'TRet> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 -> 'TRet
type internal InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 -> 'TRet
type internal InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 -> 'TRet
type internal InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 -> 'TRet
type internal InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 -> 'TRet
type internal InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 -> 'TRet
type internal InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 -> 'TRet
type internal InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 -> 'TRet
type internal InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 -> 'TRet
type internal InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 -> 'TRet
type internal InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15 -> 'TRet
type internal InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15 * 'T16 -> 'TRet
type internal InstFuncDelT<'TInst, 'TRet> = delegate of 'TInst -> 'TRet
type internal InstFuncDelT<'TInst, 'T1, 'TRet> = delegate of 'TInst * ('T1) -> 'TRet
type internal InstFuncDelT<'TInst, 'T1, 'T2, 'TRet> = delegate of 'TInst * ('T1 * 'T2) -> 'TRet
type internal InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'TRet> = delegate of 'TInst * ('T1 * 'T2 * 'T3) -> 'TRet
type internal InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'TRet> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4) -> 'TRet
type internal InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'TRet> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5) -> 'TRet
type internal InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6) -> 'TRet
type internal InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7) -> 'TRet
type internal InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8) -> 'TRet
type internal InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9) -> 'TRet
type internal InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10) -> 'TRet
type internal InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11) -> 'TRet
type internal InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12) -> 'TRet
type internal InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13) -> 'TRet
type internal InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14) -> 'TRet
type internal InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15) -> 'TRet
type internal InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15 * 'T16) -> 'TRet
type internal InstActDelC<'TInst> = delegate of 'TInst * Unit -> Unit
type internal InstActDelC<'TInst, 'T1> = delegate of 'TInst * 'T1 -> Unit
type internal InstActDelC<'TInst, 'T1, 'T2> = delegate of 'TInst * 'T1 * 'T2 -> Unit
type internal InstActDelC<'TInst, 'T1, 'T2, 'T3> = delegate of 'TInst * 'T1 * 'T2 * 'T3 -> Unit
type internal InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 -> Unit
type internal InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 -> Unit
type internal InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 -> Unit
type internal InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 -> Unit
type internal InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 -> Unit
type internal InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 -> Unit
type internal InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 -> Unit
type internal InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 -> Unit
type internal InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 -> Unit
type internal InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 -> Unit
type internal InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 -> Unit
type internal InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15 -> Unit
type internal InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16> = delegate of 'TInst * 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15 * 'T16 -> Unit
type internal InstActDelT<'TInst> = delegate of 'TInst * (Unit) -> Unit
type internal InstActDelT<'TInst, 'T1> = delegate of 'TInst * ('T1) -> Unit
type internal InstActDelT<'TInst, 'T1, 'T2> = delegate of 'TInst * ('T1 * 'T2) -> Unit
type internal InstActDelT<'TInst, 'T1, 'T2, 'T3> = delegate of 'TInst * ('T1 * 'T2 * 'T3) -> Unit
type internal InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4) -> Unit
type internal InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5) -> Unit
type internal InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6) -> Unit
type internal InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7) -> Unit
type internal InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8) -> Unit
type internal InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9) -> Unit
type internal InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10) -> Unit
type internal InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11) -> Unit
type internal InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12) -> Unit
type internal InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13) -> Unit
type internal InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14) -> Unit
type internal InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15) -> Unit
type internal InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16> = delegate of 'TInst * ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15 * 'T16) -> Unit


type internal FuncSigC<'TRet>( func: FuncDelC<'TRet> ) =
    inherit ( Unit -> 'TRet )()
    override _.Invoke( _ ) = 
        func.Invoke()
    new( fn: FuncDelT<'TRet> ) = FuncSigC<'TRet>( FuncDelC<'TRet>( fn.Invoke ) )

type internal FuncSigC<'T1, 'TRet>( func: FuncDelC<'T1, 'TRet> ) =
    inherit ( 'T1 -> 'TRet )()
    override _.Invoke( arg ) = 
        func.Invoke(arg)
    new( fn: FuncDelT<'T1,'TRet> ) = FuncSigC<'T1, 'TRet>( FuncDelC<'T1,'TRet>( fn.Invoke ) )

type internal FuncSigC<'T1, 'T2, 'TRet>( func: FuncDelC<'T1, 'T2, 'TRet> ) =
    inherit ( 'T1 -> 'T2 -> 'TRet )()
    override _.Invoke( arg ) = 
        fun arg2 -> func.Invoke( arg, arg2 )
    new( fn: FuncDelT<'T1, 'T2, 'TRet> ) = FuncSigC<'T1, 'T2, 'TRet>( FuncDelC<'T1, 'T2, 'TRet>( fun arg arg2 -> fn.Invoke( arg, arg2 ) ) )


type internal FuncSigC<'T1, 'T2, 'T3, 'TRet>( func: FuncDelC<'T1, 'T2, 'T3, 'TRet> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'TRet )()
    override _.Invoke( arg ) = 
        fun arg2 arg3 -> func.Invoke( arg, arg2, arg3 )
    new( fn: FuncDelT<'T1, 'T2, 'T3, 'TRet> ) = FuncSigC<'T1, 'T2, 'T3, 'TRet>( FuncDelC<'T1, 'T2, 'T3, 'TRet>( fun arg arg2 arg3 -> fn.Invoke( arg, arg2, arg3 ) ) )

type internal FuncSigC<'T1, 'T2, 'T3, 'T4, 'TRet>( func: FuncDelC<'T1, 'T2, 'T3, 'T4, 'TRet> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'TRet )()
    override _.Invoke( arg ) = 
        fun arg2 arg3 arg4 -> func.Invoke( arg, arg2, arg3, arg4 )
    new( fn: FuncDelT<'T1, 'T2, 'T3, 'T4, 'TRet> ) = FuncSigC<'T1, 'T2, 'T3, 'T4, 'TRet>( FuncDelC<'T1, 'T2, 'T3, 'T4, 'TRet>( fun arg arg2 arg3 arg4 -> fn.Invoke( arg, arg2, arg3, arg4 ) ) )


type internal FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'TRet>( func: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'TRet> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'TRet )()
    override _.Invoke( arg ) = 
        fun arg2 arg3 arg4 arg5 -> func.Invoke( arg, arg2, arg3, arg4, arg5 )
    new( fn: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'TRet> ) = FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'TRet>( FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'TRet>( fun arg arg2 arg3 arg4 arg5 -> fn.Invoke( arg, arg2, arg3, arg4, arg5 ) ) )


type internal FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet>( func: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'TRet )()
    override _.Invoke( arg )  = 
        fun arg2 arg3 arg4 arg5 arg6 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6 )
    new( fn: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet> ) = FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet>( FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet>( fun arg arg2 arg3 arg4 arg5 arg6 -> fn.Invoke( arg, arg2, arg3, arg4, arg5, arg6 ) ) )


type internal FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet>( func: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'TRet )()
    override _.Invoke( arg )  = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7 )
    new( fn: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet> ) = FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet>( FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet>( fun arg arg2 arg3 arg4 arg5 arg6 arg7 -> fn.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7 ) ) )


type internal FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet>( func: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'TRet )()
    override _.Invoke( arg )  = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 arg8 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8 )
    new( fn: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet> ) = FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet>( FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet>( fun arg arg2 arg3 arg4 arg5 arg6 arg7 arg8 -> fn.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8 ) ) )


type internal FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet>( func: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'TRet )()
    override _.Invoke( arg )  = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9 )
    new( fn: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet> ) = FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet>( FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet>( fun arg arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 -> fn.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9 ) ) )


type internal FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet>( func: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'TRet )()
    override _.Invoke( arg )  = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10 )
    new( fn: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet> ) = FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet>( FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet>( fun arg arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 -> fn.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10 ) ) )


type internal FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet>( func: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'TRet )()
    override _.Invoke( arg )  = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11 )
    new( fn: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet> ) = FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet>( FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet>( fun arg arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 -> fn.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11 ) ) )


type internal FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet>( func: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'TRet )()
    override _.Invoke( arg )  = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12 )
    new( fn: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet> ) = FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet>( FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet>( fun arg arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 -> fn.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12 ) ) )


type internal FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet>( func: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'TRet )()
    override _.Invoke( arg )  = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13 )
    new( fn: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet> ) = FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet>( FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet>( fun arg arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 -> fn.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13 ) ) )


type internal FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet>( func: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'TRet )()
    override _.Invoke( arg )  = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14 )
    new( fn: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet> ) = FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet>( FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet>( fun arg arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 -> fn.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14 ) ) )


type internal FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet>( func: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'T15 -> 'TRet )()
    override _.Invoke( arg )  = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15 )
    new( fn: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet> ) = FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet>( FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet>( fun arg arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 -> fn.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15 ) ) )


type internal FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet>( func: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'T15 -> 'T16 -> 'TRet )()
    override _.Invoke( arg )  = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 arg16 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16 )
    new( fn: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet> ) = FuncSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet>( FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet>( fun arg arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 arg16 -> fn.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16 ) ) )


//new( fn: FuncDelC<'T1, 'T2, 'T3, 'T4, 'TRet> ) = FuncSigT<'T1, 'T2, 'T3, 'T4, 'TRet>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'TRet>( fn.Invoke ) )
type internal FuncSigT<'TRet>( func: FuncDelT<'TRet> ) =
    inherit ( (Unit) -> 'TRet )()
    override _.Invoke( _ )  = 
        func.Invoke()
    new( fn: FuncDelC<'TRet> ) = FuncSigT<'TRet>( FuncDelT<'TRet>( fn.Invoke ) )

type internal FuncSigT<'T1, 'TRet>( func: FuncDelT<'T1, 'TRet> ) =
    inherit ( ('T1) -> 'TRet )()
    override _.Invoke( arg1 )  = 
        func.Invoke arg1
    new( fn: FuncDelC<'T1, 'TRet> ) = FuncSigT<'T1, 'TRet>( FuncDelT<'T1, 'TRet>( fn.Invoke ) )

type internal FuncSigT<'T1, 'T2, 'TRet>( func: FuncDelT<'T1, 'T2, 'TRet> ) =
    inherit ( ('T1 * 'T2) -> 'TRet )()
    override _.Invoke( arg1 )  = 
        func.Invoke arg1
    new( fn: FuncDelC<'T1, 'T2, 'TRet> ) = FuncSigT<'T1, 'T2, 'TRet>( FuncDelT<'T1, 'T2, 'TRet>( fn.Invoke ) )

type internal FuncSigT<'T1, 'T2, 'T3, 'TRet>( func: FuncDelT<'T1, 'T2, 'T3, 'TRet> ) =
    inherit ( ('T1 * 'T2 * 'T3) -> 'TRet )()
    override _.Invoke( arg1 )  = 
        func.Invoke arg1
    new( fn: FuncDelC<'T1, 'T2, 'T3, 'TRet> ) = FuncSigT<'T1, 'T2, 'T3, 'TRet>( FuncDelT<'T1, 'T2, 'T3, 'TRet>( fn.Invoke ) )

type internal FuncSigT<'T1, 'T2, 'T3, 'T4, 'TRet>( func: FuncDelT<'T1, 'T2, 'T3, 'T4, 'TRet> ) =
    inherit ( ('T1 * 'T2 * 'T3 * 'T4) -> 'TRet )()
    override _.Invoke( arg1 )  = 
        func.Invoke arg1
    new( fn: FuncDelC<'T1, 'T2, 'T3, 'T4, 'TRet> ) = FuncSigT<'T1, 'T2, 'T3, 'T4, 'TRet>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'TRet>( fn.Invoke ) )

type internal FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'TRet>( func: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'TRet> ) =
    inherit ( ('T1 * 'T2 * 'T3 * 'T4 * 'T5) -> 'TRet )()
    override _.Invoke( arg1 )  = 
        func.Invoke arg1
    new( fn: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'TRet> ) = FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'TRet>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'TRet>( fn.Invoke ) )

type internal FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet>( func: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet> ) =
    inherit ( ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6) -> 'TRet )()
    override _.Invoke( arg1 )  = 
        func.Invoke arg1
    new( fn: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet> ) = FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet>( fn.Invoke ) )

type internal FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet>( func: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet> ) =
    inherit ( ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7) -> 'TRet )()
    override _.Invoke( arg1 )  = 
        func.Invoke arg1
    new( fn: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet> ) = FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet>( fn.Invoke ) )

type internal FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet>( func: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet> ) =
    inherit ( ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8) -> 'TRet )()
    override _.Invoke( arg1 )  = 
        func.Invoke arg1
    new( fn: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet> ) = FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet>( fn.Invoke ) )

type internal FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet>( func: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet> ) =
    inherit ( ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9) -> 'TRet )()
    override _.Invoke( arg1 )  = 
        func.Invoke arg1
    new( fn: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet> ) = FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet>( fn.Invoke ) )

type internal FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet>( func: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet> ) =
    inherit ( ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10) -> 'TRet )()
    override _.Invoke( arg1 )  = 
        func.Invoke arg1
    new( fn: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet> ) = FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet>( fn.Invoke ) )

type internal FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet>( func: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet> ) =
    inherit ( ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11) -> 'TRet )()
    override _.Invoke( arg1 )  = 
        func.Invoke arg1
    new( fn: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet> ) = FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet>( fn.Invoke ) )

type internal FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet>( func: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet> ) =
    inherit ( ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12) -> 'TRet )()
    override _.Invoke( arg1 )  = 
        func.Invoke arg1
    new( fn: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet> ) = FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet>( fn.Invoke ) )

type internal FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet>( func: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet> ) =
    inherit ( ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13) -> 'TRet )()
    override _.Invoke( arg1 )  = 
        func.Invoke arg1
    new( fn: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet> ) = FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet>( fn.Invoke ) )

type internal FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet>( func: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet> ) =
    inherit ( ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14) -> 'TRet )()
    override _.Invoke( arg1 )  = 
        func.Invoke arg1
    new( fn: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet> ) = FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet>( fn.Invoke ) )

type internal FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet>( func: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet> ) =
    inherit ( ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15) -> 'TRet )()
    override _.Invoke( arg1 )  = 
        func.Invoke arg1
    new( fn: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet> ) = FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet>( fn.Invoke ) )

type internal FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet>( func: FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet> ) =
    inherit ( ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15 * 'T16) -> 'TRet )()
    override _.Invoke( arg1 )  = 
        func.Invoke arg1
    new( fn: FuncDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet> ) = FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet>( fn.Invoke ) )



//    new( fn: ActDelT<'T1, 'T2, 'T3> ) = ActSigC<'T1, 'T2, 'T3>( fn.Invoke )
type internal ActSigC = ( Unit -> Unit )

type internal ActSigC<'T1>( func: ActDelC<'T1> ) =
    inherit FuncSigC<'T1, Unit>( FuncDelC<'T1, Unit>( func.Invoke ) )
    new( fn: ActDelT<'T1> ) = ActSigC<'T1>( fn )


type internal ActSigC<'T1, 'T2>( func: ActDelC<'T1, 'T2> ) =
    inherit ( 'T1 -> 'T2 -> Unit )()
    override _.Invoke( arg ) = 
        fun arg2 -> func.Invoke( arg, arg2 )
    new( fn: ActDelT<'T1, 'T2> ) = ActSigC<'T1, 'T2>( fn.Invoke )


type internal ActSigC<'T1, 'T2, 'T3>( func: ActDelC<'T1, 'T2, 'T3> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> Unit )()
    override _.Invoke( arg ) = 
        fun arg2 arg3 -> func.Invoke( arg, arg2, arg3 )
    new( fn: ActDelT<'T1, 'T2, 'T3> ) = ActSigC<'T1, 'T2, 'T3>( fn.Invoke )


type internal ActSigC<'T1, 'T2, 'T3, 'T4>( func: ActDelC<'T1, 'T2, 'T3, 'T4> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> Unit )()
    override _.Invoke( arg ) = 
        fun arg2 arg3 arg4 -> func.Invoke( arg, arg2, arg3, arg4 )
    new( fn: ActDelT<'T1, 'T2, 'T3, 'T4> ) = ActSigC<'T1, 'T2, 'T3, 'T4>( fn.Invoke )


type internal ActSigC<'T1, 'T2, 'T3, 'T4, 'T5>( func: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> Unit )()
    override _.Invoke( arg ) = 
        fun arg2 arg3 arg4 arg5 -> func.Invoke( arg, arg2, arg3, arg4, arg5 )
    new( fn: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5> ) = ActSigC<'T1, 'T2, 'T3, 'T4, 'T5>( fn.Invoke )


type internal ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6>( func: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> Unit )()
    override _.Invoke( arg ) = 
        fun arg2 arg3 arg4 arg5 arg6 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6 )
    new( fn: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6> ) = ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6>( fn.Invoke )


type internal ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7>( func: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> Unit )()
    override _.Invoke( arg ) = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7 )
    new( fn: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7> ) = ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7>( fn.Invoke )


type internal ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8>( func: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> Unit )()
    override _.Invoke( arg ) = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 arg8 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8 )
    new( fn: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8> ) = ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8>( fn.Invoke )


type internal ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9>( func: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> Unit )()
    override _.Invoke( arg ) = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9 )
    new( fn: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9> ) = ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9>( fn.Invoke )


type internal ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10>( func: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> Unit )()
    override _.Invoke( arg ) = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10 )
    new( fn: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10> ) = ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10>( fn.Invoke )


type internal ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11>( func: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> Unit )()
    override _.Invoke( arg ) = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11 )
    new( fn: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11> ) = ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11>( fn.Invoke )


type internal ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12>( func: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> Unit )()
    override _.Invoke( arg ) = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12 )
    new( fn: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12> ) = ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12>( fn.Invoke )


type internal ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13>( func: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> Unit )()
    override _.Invoke( arg ) = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13 )
    new( fn: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13> ) = ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13>( fn.Invoke )


type internal ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14>( func: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> Unit )()
    override _.Invoke( arg ) = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14 )
    new( fn: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14> ) = ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14>( fn.Invoke )


type internal ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15>( func: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'T15 -> Unit )()
    override _.Invoke( arg ) = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15 )
    new( fn: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15> ) = ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15>( fn.Invoke )


type internal ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16>( func: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16> ) =
    inherit ( 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'T15 -> 'T16 -> Unit )()
    override _.Invoke( arg ) = 
        fun arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 arg16 -> func.Invoke( arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16 )
    new( fn: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16> ) = ActSigC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16>( fn.Invoke )


//    new( fn: ActDelC<'T1, 'T2, 'T3> ) = ActSigT<'T1, 'T2, 'T3>( fn.Invoke )
type internal ActSigT = ( (Unit) -> Unit )

type internal ActSigT<'T1>( func: ActDelT<'T1> ) =
    inherit FuncSigT<'T1, Unit>( FuncDelT<'T1, Unit>( func.Invoke ) )
    new( fn: ActDelC<'T1> ) = ActSigT<'T1>( ActDelT<'T1>(fun arg -> fn.Invoke( arg )) )
    

type internal ActSigT<'T1, 'T2>( func: ActDelT<'T1, 'T2> ) =
    inherit FuncSigT<'T1, 'T2, Unit>( FuncDelT<'T1, 'T2, Unit>( func.Invoke ) )
    new( fn: ActDelC<'T1, 'T2> ) = ActSigT<'T1, 'T2>( fn.Invoke )



type internal ActSigT<'T1, 'T2, 'T3>( func: ActDelT<'T1, 'T2, 'T3> ) =
    inherit FuncSigT<'T1, 'T2, 'T3, Unit>( FuncDelT<'T1, 'T2, 'T3, Unit>( func.Invoke ) )
    new( fn: ActDelC<'T1, 'T2, 'T3> ) = ActSigT<'T1, 'T2, 'T3>( fn.Invoke )



type internal ActSigT<'T1, 'T2, 'T3, 'T4>( func: ActDelT<'T1, 'T2, 'T3, 'T4> ) =
    inherit FuncSigT<'T1, 'T2, 'T3, 'T4, Unit>( FuncDelT<'T1, 'T2, 'T3, 'T4, Unit>( func.Invoke ) )
    new( fn: ActDelC<'T1, 'T2, 'T3, 'T4> ) = ActSigT<'T1, 'T2, 'T3, 'T4>( fn.Invoke )



type internal ActSigT<'T1, 'T2, 'T3, 'T4, 'T5>( func: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5> ) =
    inherit FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, Unit>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, Unit>( func.Invoke ) )
    new( fn: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5> ) = ActSigT<'T1, 'T2, 'T3, 'T4, 'T5>( fn.Invoke )



type internal ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6>( func: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6> ) =
    inherit FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, Unit>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, Unit>( func.Invoke ) )
    new( fn: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6> ) = ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6>( fn.Invoke )



type internal ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7>( func: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7> ) =
    inherit FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, Unit>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, Unit>( func.Invoke ) )
    new( fn: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7> ) = ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7>( fn.Invoke )



type internal ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8>( func: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8> ) =
    inherit FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, Unit>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, Unit>( func.Invoke ) )
    new( fn: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8> ) = ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8>( fn.Invoke )



type internal ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9>( func: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9> ) =
    inherit FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, Unit>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, Unit>( func.Invoke ) )
    new( fn: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9> ) = ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9>( fn.Invoke )



type internal ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10>( func: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10> ) =
    inherit FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, Unit>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, Unit>( func.Invoke ) )
    new( fn: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10> ) = ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10>( fn.Invoke )
 


type internal ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11>( func: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11> ) =
    inherit FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, Unit>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, Unit>( func.Invoke ) )
    new( fn: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11> ) = ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11>( fn.Invoke )



type internal ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12>( func: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12> ) =
    inherit FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, Unit>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, Unit>( func.Invoke ) )
    new( fn: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12> ) = ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12>( fn.Invoke )



type internal ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13>( func: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13> ) =
    inherit FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, Unit>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, Unit>( func.Invoke ) )
    new( fn: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13> ) = ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13>( fn.Invoke )



type internal ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14>( func: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14> ) =
    inherit FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, Unit>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, Unit>( func.Invoke ) )
    new( fn: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14> ) = ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14>( fn.Invoke )



type internal ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15>( func: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15> ) =
    inherit FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, Unit>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, Unit>( func.Invoke ) )
    new( fn: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15> ) = ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15>( fn.Invoke )



type internal ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16>( func: ActDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16> ) =
    inherit FuncSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, Unit>( FuncDelT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, Unit>( func.Invoke ) )
    new( fn: ActDelC<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16> ) = ActSigT<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16>( fn.Invoke )




//new( fn: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'TRet> ) = InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'TRet>( InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'TRet>( fun ins arg1 arg2 arg3 -> fn.Invoke( ins, (arg1, arg2, arg3) ) ) )


type internal InstFuncSigC<'TInst, 'TRet>( func: InstFuncDelC<'TInst, 'TRet> ) =
    inherit ( 'TInst -> Unit -> 'TRet )()
    override _.Invoke( inst: 'TInst ) = 
        fun () -> func.Invoke( inst )
    new( fn: InstFuncDelT<'TInst, 'TRet> ) = InstFuncSigC<'TInst, 'TRet>( InstFuncDelC<'TInst, 'TRet>( fun ins -> fn.Invoke( ins ) ) )

type internal InstFuncSigC<'TInst, 'T1, 'TRet>( func: InstFuncDelC<'TInst, 'T1, 'TRet> ) =
    inherit ( 'TInst -> 'T1 -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg1 -> func.Invoke( inst, arg1 )
    new( fn: InstFuncDelT<'TInst, 'T1, 'TRet> ) = InstFuncSigC<'TInst, 'T1, 'TRet>( InstFuncDelC<'TInst, 'T1, 'TRet>( fun ins arg1 -> fn.Invoke( ins, (arg1) ) ) )

type internal InstFuncSigC<'TInst, 'T1, 'T2, 'TRet>( func: InstFuncDelC<'TInst, 'T1, 'T2, 'TRet> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 -> func.Invoke( inst, arg1, arg2 )
    new( fn: InstFuncDelT<'TInst, 'T1, 'T2, 'TRet> ) = InstFuncSigC<'TInst, 'T1, 'T2, 'TRet>( InstFuncDelC<'TInst, 'T1, 'T2, 'TRet>( fun ins arg1 arg2 -> fn.Invoke( ins, (arg1, arg2) ) ) )

type internal InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'TRet>( func: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'TRet> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 -> func.Invoke( inst, arg1, arg2, arg3 )
    new( fn: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'TRet> ) = InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'TRet>( InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'TRet>( fun ins arg1 arg2 arg3 -> fn.Invoke( ins, (arg1, arg2, arg3) ) ) )

type internal InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'TRet>( func: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'TRet> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 -> func.Invoke( inst, arg1, arg2, arg3, arg4 )
    new( fn: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'TRet> ) = InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'TRet>( InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'TRet>( fun ins arg1 arg2 arg3 arg4 -> fn.Invoke( ins, (arg1, arg2, arg3, arg4) ) ) )

type internal InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'TRet>( func: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'TRet> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5 )
    new( fn: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'TRet> ) = InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'TRet>( InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'TRet>( fun ins arg1 arg2 arg3 arg4 arg5 -> fn.Invoke( ins, (arg1, arg2, arg3, arg4, arg5) ) ) )

type internal InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet>( func: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6 )
    new( fn: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet> ) = InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet>( InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 -> fn.Invoke( ins, (arg1, arg2, arg3, arg4, arg5, arg6) ) ) )

type internal InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet>( func: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7 )
    new( fn: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet> ) = InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet>( InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 -> fn.Invoke( ins, (arg1, arg2, arg3, arg4, arg5, arg6, arg7) ) ) )

type internal InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet>( func: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8 )
    new( fn: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet> ) = InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet>( InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 -> fn.Invoke( ins, (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) ) ) )


type internal InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet>( func: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9 )
    new( fn: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet> ) = InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet>( InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 -> fn.Invoke( ins, (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) ) ) )


type internal InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet>( func: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10 )
    new( fn: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet> ) = InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet>( InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 -> fn.Invoke( ins, (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) ) ) )


type internal InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet>( func: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11 )
    new( fn: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet> ) = InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet>( InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 -> fn.Invoke( ins, (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) ) ) )


type internal InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet>( func: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12 )
    new( fn: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet> ) = InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet>( InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 -> fn.Invoke( ins, (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) ) ) )


type internal InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet>( func: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13 )
    new( fn: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet> ) = InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet>( InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 -> fn.Invoke( ins, (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) ) ) )


type internal InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet>( func: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14 )
    new( fn: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet> ) = InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet>( InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 -> fn.Invoke( ins, (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) ) ) )


type internal InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet>( func: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'T15 -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15 )
    new( fn: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet> ) = InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet>( InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 -> fn.Invoke( ins, (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) ) ) )


type internal InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet>( func: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'T15 -> 'T16 -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 arg16 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16 )
    new( fn: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet> ) = InstFuncSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet>( InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 arg16 -> fn.Invoke( ins, (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) ) ) )



//new( fn: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'TRet> ) = InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'TRet>( fun ins (arg1, arg2, arg3) -> fn.Invoke( ins, arg1, arg2, arg3 ) )
type internal InstFuncSigT<'TInst, 'TRet>( func: InstFuncDelT<'TInst, 'TRet> ) =
    inherit ( 'TInst -> (Unit) -> 'TRet )()
    override _.Invoke( inst ) = 
        fun () -> func.Invoke( inst )
    new( fn: InstFuncDelC<'TInst, 'TRet> ) = InstFuncSigT<'TInst, 'TRet>( InstFuncDelT<'TInst, 'TRet>( fun ins  -> fn.Invoke( ins ) ) )


type internal InstFuncSigT<'TInst, 'T1, 'TRet>( func: InstFuncDelT<'TInst, 'T1, 'TRet> ) =
    inherit ( 'TInst -> ('T1) -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstFuncDelC<'TInst, 'T1, 'TRet> ) = InstFuncSigT<'TInst, 'T1, 'TRet>( InstFuncDelT<'TInst, 'T1, 'TRet>( fun ins (arg1) -> fn.Invoke( ins, arg1) ) )



type internal InstFuncSigT<'TInst, 'T1, 'T2, 'TRet>( func: InstFuncDelT<'TInst, 'T1, 'T2, 'TRet> ) =
    inherit ( 'TInst -> ('T1 * 'T2) -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstFuncDelC<'TInst, 'T1, 'T2, 'TRet> ) = InstFuncSigT<'TInst, 'T1, 'T2, 'TRet>( InstFuncDelT<'TInst, 'T1, 'T2, 'TRet>( fun ins (arg1, arg2) -> fn.Invoke( ins, arg1, arg2 ) ) )



type internal InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'TRet>( func: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'TRet> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3) -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'TRet> ) = InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'TRet>( InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'TRet>( fun ins (arg1, arg2, arg3 ) -> fn.Invoke( ins, arg1, arg2, arg3 ) ) )



type internal InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'TRet>( func: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'TRet> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4) -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'TRet> ) = InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'TRet>( InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'TRet>( fun ins (arg1, arg2, arg3, arg4 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4 ) ) )



type internal InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'TRet>( func: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'TRet> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5) -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'TRet> ) = InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'TRet>( InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'TRet>( fun ins (arg1, arg2, arg3, arg4, arg5 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5 ) ) )



type internal InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet>( func: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6) -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet> ) = InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet>( InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TRet>( fun ins (arg1, arg2, arg3, arg4, arg5, arg6 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6 ) ) )



type internal InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet>( func: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7) -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet> ) = InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet>( InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TRet>( fun ins (arg1, arg2, arg3, arg4, arg5, arg6, arg7 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7 ) ) )



type internal InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet>( func: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8) -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet> ) = InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet>( InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TRet>( fun ins (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8 ) ) )



type internal InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet>( func: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9) -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet> ) = InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet>( InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TRet>( fun ins (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9 ) ) )



type internal InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet>( func: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10) -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet> ) = InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet>( InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TRet>( fun ins (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10 ) ) )



type internal InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet>( func: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11) -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet> ) = InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet>( InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TRet>( fun ins (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11 ) ) )



type internal InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet>( func: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12) -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet> ) = InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet>( InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TRet>( fun ins (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12 ) ) )



type internal InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet>( func: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13) -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet> ) = InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet>( InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TRet>( fun ins (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13 ) ) )



type internal InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet>( func: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14) -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet> ) = InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet>( InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TRet>( fun ins (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14 ) ) )



type internal InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet>( func: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15) -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet> ) = InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet>( InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TRet>( fun ins (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15 ) ) )



type internal InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet>( func: InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15 * 'T16) -> 'TRet )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstFuncDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet> ) = InstFuncSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet>( InstFuncDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TRet>( fun ins (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16 ) ) )



//new( fn: InstActDelT<'TInst, 'T1, 'T2, 'T3> ) = InstActSigC<'TInst, 'T1, 'T2, 'T3>( fun ins arg1 arg2 arg3 -> fn.Invoke( ins, (arg1, arg2, arg3) ) )

type internal InstActSigC<'TInst>( func: InstActDelC<'TInst> ) =
    inherit ( 'TInst -> Unit -> Unit )()
    override _.Invoke( inst ) = 
        fun () -> func.Invoke( inst, () )
    //new( fn: InstActDelT<'TInst> ) = InstActSigC<'TInst>( fn :> InstActDelT<'TInst> )


type internal InstActSigC<'TInst, 'T1>( func: InstActDelC<'TInst, 'T1> ) =
    inherit ( 'TInst -> 'T1 -> Unit )()
    override _.Invoke( inst ) = 
        fun arg1 -> func.Invoke( inst, arg1 )
    new( fn: InstActDelT<'TInst, 'T1> ) = InstActSigC<'TInst, 'T1>( InstActDelC<'TInst, 'T1>( fun ins arg1 -> fn.Invoke( ins, arg1 ) ) )



type internal InstActSigC<'TInst, 'T1, 'T2>( func: InstActDelC<'TInst, 'T1, 'T2> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> Unit )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 -> func.Invoke( inst, arg1, arg2 )
    new( fn: InstActDelT<'TInst, 'T1, 'T2> ) = InstActSigC<'TInst, 'T1, 'T2>( fun ins arg1 arg2 -> fn.Invoke( ins, ( arg1, arg2 ) ) )



type internal InstActSigC<'TInst, 'T1, 'T2, 'T3>( func: InstActDelC<'TInst, 'T1, 'T2, 'T3> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> Unit )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 -> func.Invoke( inst, arg1, arg2, arg3 )
    new( fn: InstActDelT<'TInst, 'T1, 'T2, 'T3> ) = InstActSigC<'TInst, 'T1, 'T2, 'T3>( fun ins arg1 arg2 arg3 -> fn.Invoke( ins, ( arg1, arg2, arg3 ) ) )



type internal InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4>( func: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> Unit )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 -> func.Invoke( inst, arg1, arg2, arg3, arg4 )
    new( fn: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4> ) = InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4>( fun ins arg1 arg2 arg3 arg4 -> fn.Invoke( ins, ( arg1, arg2, arg3, arg4 ) ) )



type internal InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5>( func: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> Unit )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5 )
    new( fn: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5> ) = InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5>( fun ins arg1 arg2 arg3 arg4 arg5 -> fn.Invoke( ins, ( arg1, arg2, arg3, arg4, arg5 ) ) )



type internal InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6>( func: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> Unit )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6 )
    new( fn: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6> ) = InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 -> fn.Invoke( ins, ( arg1, arg2, arg3, arg4, arg5, arg6 ) ) )



type internal InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7>( func: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> Unit )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7 )
    new( fn: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7> ) = InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 -> fn.Invoke( ins, ( arg1, arg2, arg3, arg4, arg5, arg6, arg7 ) ) )



type internal InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8>( func: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> Unit )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8 )
    new( fn: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8> ) = InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 -> fn.Invoke( ins, ( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8 ) ) )



type internal InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9>( func: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> Unit )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9 )
    new( fn: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9> ) = InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 -> fn.Invoke( ins, ( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9 ) ) )



type internal InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10>( func: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> Unit )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10 )
    new( fn: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10> ) = InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 -> fn.Invoke( ins, ( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10 ) ) )



type internal InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11>( func: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> Unit )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11 )
    new( fn: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11> ) = InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 -> fn.Invoke( ins, ( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11 ) ) )



type internal InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12>( func: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> Unit )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12 )
    new( fn: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12> ) = InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 -> fn.Invoke( ins, ( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12 ) ) )



type internal InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13>( func: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> Unit )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13 )
    new( fn: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13> ) = InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 -> fn.Invoke( ins, ( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13 ) ) )



type internal InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14>( func: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> Unit )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14 )
    new( fn: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14> ) = InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 -> fn.Invoke( ins, ( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14 ) ) )



type internal InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15>( func: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'T15 -> Unit )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15 )
    new( fn: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15> ) = InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 -> fn.Invoke( ins, ( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15 ) ) )



type internal InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16>( func: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16> ) =
    inherit ( 'TInst -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'T15 -> 'T16 -> Unit )()
    override _.Invoke( inst ) = 
        fun arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 arg16 -> func.Invoke( inst, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16 )
    new( fn: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16> ) = InstActSigC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16>( fun ins arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 arg16 -> fn.Invoke( ins, ( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16 ) ) )



//new( fn: InstActDelC<'TInst, 'T1, 'T2, 'T3> ) = InstActSigT<'TInst, 'T1, 'T2, 'T3>( fun ins (arg1, arg2, arg3) -> fn.Invoke( ins, arg1, arg2, arg3 ) )

type internal InstActSigT<'TInst>( func: InstActDelT<'TInst> ) =
    inherit ( 'TInst -> (Unit) -> Unit )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    //new( fn: InstActDelC<'TInst> ) = InstActSigT<'TInst>( fun ins -> fn.Invoke( ins ) )


type internal InstActSigT<'TInst, 'T1>( func: InstActDelT<'TInst, 'T1> ) =
    inherit ( 'TInst -> ('T1) -> Unit )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstActDelC<'TInst, 'T1> ) = InstActSigT<'TInst, 'T1>( InstActDelT<'TInst, 'T1>( fun ins arg -> fn.Invoke(ins, arg) ) )


type internal InstActSigT<'TInst, 'T1, 'T2>( func: InstActDelT<'TInst, 'T1, 'T2> ) =
    inherit ( 'TInst -> ('T1 * 'T2) -> Unit )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstActDelC<'TInst, 'T1, 'T2> ) = InstActSigT<'TInst, 'T1, 'T2>( fun ins ( arg1, arg2 ) -> fn.Invoke( ins, arg1, arg2 ) )


type internal InstActSigT<'TInst, 'T1, 'T2, 'T3>( func: InstActDelT<'TInst, 'T1, 'T2, 'T3> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3) -> Unit )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstActDelC<'TInst, 'T1, 'T2, 'T3> ) = InstActSigT<'TInst, 'T1, 'T2, 'T3>( fun ins ( arg1, arg2, arg3 ) -> fn.Invoke( ins, arg1, arg2, arg3 ) )


type internal InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4>( func: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4) -> Unit )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4> ) = InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4>( fun ins ( arg1, arg2, arg3, arg4 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4 ) )


type internal InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5>( func: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5) -> Unit )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5> ) = InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5>( fun ins ( arg1, arg2, arg3, arg4, arg5 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5 ) )


type internal InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6>( func: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6) -> Unit )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6> ) = InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6>( fun ins ( arg1, arg2, arg3, arg4, arg5, arg6 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6 ) )


type internal InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7>( func: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7) -> Unit )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7> ) = InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7>( fun ins ( arg1, arg2, arg3, arg4, arg5, arg6, arg7 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7 ) )


type internal InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8>( func: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8) -> Unit )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8> ) = InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8>( fun ins ( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8 ) )


type internal InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9>( func: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9) -> Unit )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9> ) = InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9>( fun ins ( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9 ) )


type internal InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10>( func: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10) -> Unit )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10> ) = InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10>( fun ins ( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10 ) )


type internal InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11>( func: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11) -> Unit )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11> ) = InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11>( fun ins ( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11 ) )


type internal InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12>( func: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12) -> Unit )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12> ) = InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12>( fun ins ( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12 ) )


type internal InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13>( func: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13) -> Unit )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13> ) = InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13>( fun ins ( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13 ) )


type internal InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14>( func: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14) -> Unit )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14> ) = InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14>( fun ins ( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14 ) )


type internal InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15>( func: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15) -> Unit )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15> ) = InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15>( fun ins ( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15 ) )


type internal InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16>( func: InstActDelT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16> ) =
    inherit ( 'TInst -> ('T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15 * 'T16) -> Unit )()
    override _.Invoke( inst ) = 
        fun arg -> func.Invoke( inst, arg )
    new( fn: InstActDelC<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16> ) = InstActSigT<'TInst, 'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16>( fun ins ( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16 ) -> fn.Invoke( ins, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16 ) )









module internal DelegateCreator =
    let GetActionDelegateAndSig (args: Type[]) : Type*Type =
        let genParams = args

        match args.Length with
        | 00 -> (typeof<ActDelT>, typeof<ActSigT>)
        | 01 -> (typedefof<ActDelC<_>>.MakeGenericType genParams, typedefof<ActSigT<_>>.MakeGenericType genParams)
        | 02 -> (typedefof<ActDelC<_,_>>.MakeGenericType genParams, typedefof<ActSigT<_,_>>.MakeGenericType genParams)
        | 03 -> (typedefof<ActDelC<_,_,_>>.MakeGenericType genParams, typedefof<ActSigT<_,_,_>>.MakeGenericType genParams)
        | 04 -> (typedefof<ActDelC<_,_,_,_>>.MakeGenericType genParams, typedefof<ActSigT<_,_,_,_>>.MakeGenericType genParams)
        | 05 -> (typedefof<ActDelC<_,_,_,_,_>>.MakeGenericType genParams, typedefof<ActSigT<_,_,_,_,_>>.MakeGenericType genParams)
        | 06 -> (typedefof<ActDelC<_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<ActSigT<_,_,_,_,_,_>>.MakeGenericType genParams)
        | 07 -> (typedefof<ActDelC<_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<ActSigT<_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 08 -> (typedefof<ActDelC<_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<ActSigT<_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 09 -> (typedefof<ActDelC<_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<ActSigT<_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 10 -> (typedefof<ActDelC<_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<ActSigT<_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 11 -> (typedefof<ActDelC<_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<ActSigT<_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 12 -> (typedefof<ActDelC<_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<ActSigT<_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 13 -> (typedefof<ActDelC<_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<ActSigT<_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 14 -> (typedefof<ActDelC<_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<ActSigT<_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 15 -> (typedefof<ActDelC<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<ActSigT<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 16 -> (typedefof<ActDelC<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<ActSigT<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | _ -> raise <| NotImplementedException( "More than 16 args not implemented")


    let GetInstanceActionDelegateAndSig (objType: Type) (args: Type[]) : Type*Type =
        let genParams = Array.append <| [| objType; |] <| args

        match args.Length with
        | 00 -> (typedefof<InstActDelC<_>>.MakeGenericType genParams, typedefof<InstActSigT<_>>.MakeGenericType genParams)
        | 01 -> (typedefof<InstActDelC<_,_>>.MakeGenericType genParams, typedefof<InstActSigT<_,_>>.MakeGenericType genParams)
        | 02 -> (typedefof<InstActDelC<_,_,_>>.MakeGenericType genParams, typedefof<InstActSigT<_,_,_>>.MakeGenericType genParams)
        | 03 -> (typedefof<InstActDelC<_,_,_,_>>.MakeGenericType genParams, typedefof<InstActSigT<_,_,_,_>>.MakeGenericType genParams)
        | 04 -> (typedefof<InstActDelC<_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstActSigT<_,_,_,_,_>>.MakeGenericType genParams)
        | 05 -> (typedefof<InstActDelC<_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstActSigT<_,_,_,_,_,_>>.MakeGenericType genParams)
        | 06 -> (typedefof<InstActDelC<_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstActSigT<_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 07 -> (typedefof<InstActDelC<_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstActSigT<_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 08 -> (typedefof<InstActDelC<_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstActSigT<_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 09 -> (typedefof<InstActDelC<_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstActSigT<_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 10 -> (typedefof<InstActDelC<_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstActSigT<_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 11 -> (typedefof<InstActDelC<_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstActSigT<_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 12 -> (typedefof<InstActDelC<_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstActSigT<_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 13 -> (typedefof<InstActDelC<_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstActSigT<_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 14 -> (typedefof<InstActDelC<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstActSigT<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 15 -> (typedefof<InstActDelC<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstActSigT<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 16 -> (typedefof<InstActDelC<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstActSigT<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | _ -> raise <| NotImplementedException( "More than 16 args not implemented")

    let GetFuncDelegateAndSig (args: Type[]) (ret: Type) : Type*Type =
        let genParams = Array.append <| args <| [| ret; |]

        match args.Length with
        | 00 -> (typedefof<FuncDelC<_>>.MakeGenericType genParams, typedefof<FuncSigT<_>>.MakeGenericType genParams)
        | 01 -> (typedefof<FuncDelC<_,_>>.MakeGenericType genParams, typedefof<FuncSigT<_,_>>.MakeGenericType genParams)
        | 02 -> (typedefof<FuncDelC<_,_,_>>.MakeGenericType genParams, typedefof<FuncSigT<_,_,_>>.MakeGenericType genParams)
        | 03 -> (typedefof<FuncDelC<_,_,_,_>>.MakeGenericType genParams, typedefof<FuncSigT<_,_,_,_>>.MakeGenericType genParams)
        | 04 -> (typedefof<FuncDelC<_,_,_,_,_>>.MakeGenericType genParams, typedefof<FuncSigT<_,_,_,_,_>>.MakeGenericType genParams)
        | 05 -> (typedefof<FuncDelC<_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<FuncSigT<_,_,_,_,_,_>>.MakeGenericType genParams)
        | 06 -> (typedefof<FuncDelC<_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<FuncSigT<_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 07 -> (typedefof<FuncDelC<_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<FuncSigT<_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 08 -> (typedefof<FuncDelC<_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<FuncSigT<_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 09 -> (typedefof<FuncDelC<_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<FuncSigT<_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 10 -> (typedefof<FuncDelC<_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<FuncSigT<_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 11 -> (typedefof<FuncDelC<_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<FuncSigT<_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 12 -> (typedefof<FuncDelC<_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<FuncSigT<_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 13 -> (typedefof<FuncDelC<_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<FuncSigT<_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 14 -> (typedefof<FuncDelC<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<FuncSigT<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 15 -> (typedefof<FuncDelC<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<FuncSigT<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 16 -> (typedefof<FuncDelC<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<FuncSigT<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | _ -> raise <| NotImplementedException( "More than 16 args not implemented")


    let GetInstanceFuncDelegateAndSig (objType: Type) (args: Type[]) (ret: Type) : Type*Type =
        let genParams = 
            [| objType; |]
            |> Array.append <| args
            |> Array.append <| [| ret; |]

        match args.Length with
        | 00 -> (typedefof<InstFuncDelC<_,_>>.MakeGenericType genParams, typedefof<InstFuncSigT<_,_>>.MakeGenericType genParams)
        | 01 -> (typedefof<InstFuncDelC<_,_,_>>.MakeGenericType genParams, typedefof<InstFuncSigT<_,_,_>>.MakeGenericType genParams)
        | 02 -> (typedefof<InstFuncDelC<_,_,_,_>>.MakeGenericType genParams, typedefof<InstFuncSigT<_,_,_,_>>.MakeGenericType genParams)
        | 03 -> (typedefof<InstFuncDelC<_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstFuncSigT<_,_,_,_,_>>.MakeGenericType genParams)
        | 04 -> (typedefof<InstFuncDelC<_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstFuncSigT<_,_,_,_,_,_>>.MakeGenericType genParams)
        | 05 -> (typedefof<InstFuncDelC<_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstFuncSigT<_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 06 -> (typedefof<InstFuncDelC<_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstFuncSigT<_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 07 -> (typedefof<InstFuncDelC<_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstFuncSigT<_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 08 -> (typedefof<InstFuncDelC<_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstFuncSigT<_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 09 -> (typedefof<InstFuncDelC<_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstFuncSigT<_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 10 -> (typedefof<InstFuncDelC<_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstFuncSigT<_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 11 -> (typedefof<InstFuncDelC<_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstFuncSigT<_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 12 -> (typedefof<InstFuncDelC<_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstFuncSigT<_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 13 -> (typedefof<InstFuncDelC<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstFuncSigT<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 14 -> (typedefof<InstFuncDelC<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstFuncSigT<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 15 -> (typedefof<InstFuncDelC<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstFuncSigT<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | 16 -> (typedefof<InstFuncDelC<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams, typedefof<InstFuncSigT<_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_>>.MakeGenericType genParams)
        | _ -> raise <| NotImplementedException( "More than 16 args not implemented")
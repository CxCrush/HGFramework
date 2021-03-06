﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_PolygonCollider2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.PolygonCollider2D o;
			o=new UnityEngine.PolygonCollider2D();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPath(IntPtr l) {
		try {
			UnityEngine.PolygonCollider2D self=(UnityEngine.PolygonCollider2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPath(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPath(IntPtr l) {
		try {
			UnityEngine.PolygonCollider2D self=(UnityEngine.PolygonCollider2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2[] a2;
			checkType(l,3,out a2);
			self.SetPath(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTotalPointCount(IntPtr l) {
		try {
			UnityEngine.PolygonCollider2D self=(UnityEngine.PolygonCollider2D)checkSelf(l);
			var ret=self.GetTotalPointCount();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreatePrimitive(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.PolygonCollider2D self=(UnityEngine.PolygonCollider2D)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.CreatePrimitive(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.PolygonCollider2D self=(UnityEngine.PolygonCollider2D)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,3,out a2);
				self.CreatePrimitive(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.PolygonCollider2D self=(UnityEngine.PolygonCollider2D)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,3,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,4,out a3);
				self.CreatePrimitive(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_points(IntPtr l) {
		try {
			UnityEngine.PolygonCollider2D self=(UnityEngine.PolygonCollider2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.points);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_points(IntPtr l) {
		try {
			UnityEngine.PolygonCollider2D self=(UnityEngine.PolygonCollider2D)checkSelf(l);
			UnityEngine.Vector2[] v;
			checkType(l,2,out v);
			self.points=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pathCount(IntPtr l) {
		try {
			UnityEngine.PolygonCollider2D self=(UnityEngine.PolygonCollider2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pathCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pathCount(IntPtr l) {
		try {
			UnityEngine.PolygonCollider2D self=(UnityEngine.PolygonCollider2D)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.pathCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.PolygonCollider2D");
		addMember(l,GetPath);
		addMember(l,SetPath);
		addMember(l,GetTotalPointCount);
		addMember(l,CreatePrimitive);
		addMember(l,"points",get_points,set_points,true);
		addMember(l,"pathCount",get_pathCount,set_pathCount,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.PolygonCollider2D),typeof(UnityEngine.Collider2D));
	}
}

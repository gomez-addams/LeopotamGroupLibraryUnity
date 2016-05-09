﻿//-------------------------------------------------------
// LeopotamGroupLibrary for unity3d
// Copyright (c) 2012-2016 Leopotam <leopotam@gmail.com>
//-------------------------------------------------------

using UnityEngine;

namespace LeopotamGroup.Pooling {
    /// <summary>
    /// Recycle instance after time (if it was spawned from pool).
    /// Dont use it on swarm spawns of prefab (use custom recycling instead).
    /// </summary>
    public sealed class RecycleAfterTime : MonoBehaviour {
        [SerializeField]
        float _timeout = 1f;

        float _endTime;

        void OnEnable () {
            _endTime = Time.time + _timeout;
        }

        void LateUpdate () {
            if (Time.time >= _endTime) {
                OnRecycle ();
            }
        }

        void OnRecycle () {
            var poolObj = GetComponent <PoolObject> ();
            if (poolObj != null) {
                poolObj.Recycle ();
            } else {
                gameObject.SetActive (false);
            }
        }
    }
}
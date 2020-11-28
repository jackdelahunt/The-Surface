using System;
using UnityEngine;
using UnityEngine.AI;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (UnityEngine.AI.NavMeshAgent))]
    [RequireComponent(typeof (ThirdPersonCharacter))]
    public class AICharacterControl : MonoBehaviour
    {
        public UnityEngine.AI.NavMeshAgent agent { get; private set; }             // the navmesh agent required for the path finding
        public ThirdPersonCharacter character { get; private set; } // the character we are controlling
        public Transform target;
        private Rigidbody myRigidBody;


        private void Start()
        {
            // get the components on the object we need ( should not be null due to require component so no need to check )
            agent = GetComponentInChildren<UnityEngine.AI.NavMeshAgent>();
            character = GetComponent<ThirdPersonCharacter>();
            myRigidBody = GetComponent<Rigidbody>();
	        agent.updateRotation = false;
	        agent.updatePosition = true;
            target = GameObject.FindGameObjectWithTag("Player").transform;
            toggleRagdoll();
        }


        private void Update()
        {
            if (target != null)
                agent.SetDestination(target.position);

            if (agent.remainingDistance > agent.stoppingDistance)
                character.Move(agent.desiredVelocity, false, false);
            else
                character.Move(Vector3.zero, false, false);
        }


        public void SetTarget(Transform target)
        {
            this.target = target;
        }

        public void kill() {

            // don't kill while falling
            if (myRigidBody.velocity.y < -5)
                return;

            toggleRagdoll();
            GetComponent<Animator>().enabled = false;

            Rigidbody rb = GetComponent<Rigidbody>();
            rb.useGravity = false;
            rb.isKinematic = true;
            GetComponent<CapsuleCollider>().enabled = false;
            GetComponent<NavMeshAgent>().enabled = false;
            GetComponent<ThirdPersonCharacter>().enabled = false;
            GetComponent<AICharacterControl>().enabled = false;

            Invoke("DeleteSelf", 3f);
        }

        public void toggleRagdoll() {
            Collider[] cols = GetComponentsInChildren<Collider>();
            Rigidbody[] rigs = GetComponentsInChildren<Rigidbody>();

            foreach(Collider col in cols) {
                col.enabled = !col.enabled;
            }

            foreach(Rigidbody rig in rigs) {
                rig.useGravity = !rig.useGravity;
            }

            GetComponent<Collider>().enabled = true;
            GetComponent<Rigidbody>().useGravity = true;
        }

        public void DeleteSelf() {
            Destroy(gameObject);
        }

        
    }
}

import * as THREE from "three"

import {OrbitControls} from "three/examples/jsm/controls/OrbitControls"
import {OBJLoader} from "three/examples/jsm/loaders/OBJLoader"

const canvasElement = document.getElementById("canvasElement") as HTMLCanvasElement;

const renderer = new THREE.WebGLRenderer({canvas: canvasElement, antialias: true});
const scene = new THREE.Scene();
const camera = new THREE.PerspectiveCamera(90, 4/3);
const light = new THREE.DirectionalLight(0xfaaaaa, 0.7);
// const cube = new THREE.Mesh(new THREE.BoxGeometry(1,1,1), new THREE.MeshStandardMaterial({color: 0xaaffaa}));
const control = new OrbitControls(camera, canvasElement);
const loader = new OBJLoader();
let model : THREE.Group;

loader.load("models/bunny.obj",
    (obj) =>
    {
        model = obj;
        scene.add(model);
        model.scale.set(10,10,10);
    }
)


light.position.set(1,1,2);
light.lookAt(0,0,0);
// cube.position.set(0,0,0);
camera.translateOnAxis(new THREE.Vector3(1,1,1), 3);
camera.lookAt(0,0,0);

scene.add(camera);
scene.add(light);
// scene.add(cube);

renderer.setAnimationLoop(renderLoop)

function renderLoop() : void
{
    control.update();

    renderer.render(scene, camera);
}
class TestLoginForm extends React.Component {
  constructor(props) {
  super(props);
  // handle initialization activities
  }
  handleChangeEvents(event) {
  //handle change events
  }
  handleSubmitevents(event) {
  // handle submit events
  }
  handlePasswordChange(event){
  //handle password change events
  }
  render() {
  return (
  <div className=" TestLoginForm ">
  <form onSubmit={this.handleSubmitevents}>
  {
  //handle error condition
  }
  <label>User Name</label>
  <input type="text" data-test="username" value={this.state.username} onChange={this.handleChangeEvents} />
  <label>Password</label>
  <input type="password" data-test="password" value={this.state.password} onChange={this. handlePasswordChange } />
  <input type="submit" value="Log In" data-test="submit" />
  </form>
  );
  }
  }

export default function Login(props) {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  function performValidation() {
  return username.length > 0 && password.length > 0;
  }
  function handleSubmit(event) {
  event.preventDefault();
  }
  return (
  <div className="Login">
  <form onSubmit={handleSubmit}>
  <FormGroup controlId="username" bsSize="large">
  <ControlLabel>Username</ControlLabel>
  <FormControl
  autoFocus
  type="text"
  value={username}
  onChange={e => setUsername(e.target.value)}
  />
  </FormGroup>
  <FormGroup controlId="password" bsSize="large">
  <ControlLabel>Password</ControlLabel>
  <FormControl
  value={password}
  onChange={e => setPassword(e.target.value)}
  type="password"
  />
  </FormGroup>
  <Button block bsSize="large" disabled={!performValidation()} type="submit">
  Login
  </Button>
  </form>
  </div>
  );
  }
// pages/index.tsx
import ChuckNorrisJoke from '../components/ChuckNorrisJoke';

const IndexPage: React.FC = () => {
  return (
    <div>
      <h1>Welcome to Chuck Norris Jokes</h1>
      <ChuckNorrisJoke />
    </div>
  );
};

export default IndexPage;
